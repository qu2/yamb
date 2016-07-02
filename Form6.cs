/* Twitter page (Provisional) */

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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        // 初期画面
        private void Form6_Load(object sender, EventArgs e)
        {
            webTwitter.Url = new Uri("https://twitter.com/");
        }

        // ボタン類
        private void TwiBack_Click(object sender, EventArgs e)
        {
            webTwitter.GoBack();
        }

        private void TwiGo_Click(object sender, EventArgs e)
        {
            webTwitter.GoForward();
        }
    }
}
