/* Form3 Twitter View page */

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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // Twitterのページを表示
        private void Form4_Load(object sender, EventArgs e)
        {
            twitterBrowser.Url = new Uri("https://twitter.com/Lv470/");
        }
    }
}
