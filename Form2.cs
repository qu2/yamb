/* archive.is page */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yamb
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // 初期画面
        private void Form2_Load(object sender, EventArgs e)
        {
            archiveisBrowser.Url = new Uri("http://archive.is/");
        }

        // 魚拓をとりやすくすると思う
        private void btnInput_Click(object sender, EventArgs e)
        {
            HtmlElementCollection all = archiveisBrowser.Document.All;
            HtmlElementCollection forms = all.GetElementsByName("url");
            forms[0].InnerText = ("http://www.3751chat.com/ChatRoom?room_id=");
        }
    }
}
