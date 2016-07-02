/* yamb (yet another minakoi browser) code by @Lv470 */
/* ver 1.0.0 - beta 2.0 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yamb
{
    public partial class yamb : Form
    {
        public yamb()
        {
            InitializeComponent();
        }

        // 初期画面
        private void yamb_Load(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://www.3751chat.com/");
            
            // 起動時にTwitterも同時に起動
            Form6 form6 = new Form6();
            form6.Show();
        }

        // target="_blank"を無効
        private void Browser_NewWindow(object sender, CancelEventArgs e)
        {
            WebBrowser wb = (WebBrowser)sender;
            string txt = wb.StatusText;
            if (txt != "")
            {
                browser.Navigate(txt);
            }
            e.Cancel = true;
        }

        // トップに戻る
        private void btnTop_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://www.3751chat.com/");
        }

        // ページを進む
        private void btnBack_Click(object sender, EventArgs e)
        {
            browser.GoBack();
        }

        // ページを戻る
        private void btnNext_Click(object sender, EventArgs e)
        {
            browser.GoForward();
        }

        // ページのリロード
        private void btnReload_Click(object sender, EventArgs e)
        {
            browser.Refresh();
        }

        private void browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            // URL表示処理
            urlBox.Text = browser.Url.ToString();

            // 行くページがある時のみボタンを有効
            btnBack.Enabled = browser.CanGoBack;
            btnNext.Enabled = browser.CanGoForward;
        }

        // Enter投下でurlBoxのURLへ移動
        private void urlBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                browser.Url = new Uri(urlBox.Text);
            }
        }

        // 魚拓(archive.is)を開かせる
        private void goArchiveis_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        // スクショ撮影(bmp形式)
        // 画質悪そう
        private void btnSS_Click(object sender, EventArgs e)
        {
            Rectangle rc = Screen.PrimaryScreen.Bounds;
            Bitmap bmp = new Bitmap(rc.Width, rc.Height, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(rc.X, rc.Y, 0, 0, rc.Size, CopyPixelOperation.SourceCopy);
            }
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\SS.bmp";
            bmp.Save(filePath, ImageFormat.Bmp);
        }

        // 中学生ルームへ移動
        private void lnkJhs_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://www.3751chat.com/ChatRoom?room_id=72117");
        }

        // 雑談ルームへ移動
        private void lnkChat_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://www.3751chat.com/ChatRoom?room_id=2");
        }

        // ルブルへ移動
        private void lnkLuvul_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://chat.luvul.net/");
            // 警告
            MessageBox.Show("ルブルチャットではyambの一部機能が正常に動作しないことがあります。", "yamb");
        }

        // ページ移動(yamb/Developers) 
        private void dev_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        // 連投
        // ループ処理未実装 ループ処理できない(ぶちぎれ)(おこだよ)
        private void bakugeki_Click(object sender, EventArgs e)
        {
            string random = Guid.NewGuid().ToString("N").Substring(0, 4);

            HtmlElementCollection all = browser.Document.All;
            HtmlElementCollection forms = all.GetElementsByName("chat");
            forms[0].InnerText = ("Hello(" + random + (")"));

            SendKeys.Send("{ENTER}");
        }

        // 駐屯
        // ループ処理未実装 誰かループ処理つけてください(土下座)
        private void stay_Click(object sender, EventArgs e)
        {
            string random = Guid.NewGuid().ToString("N").Substring(0, 4);

            HtmlElementCollection all = browser.Document.All;
            HtmlElementCollection forms = all.GetElementsByName("chat");
            forms[0].InnerText = ("Hello(" + random + (")"));

            SendKeys.Send("{ENTER}");
        }

        // ルーム作成
        private void roomMake_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://www.3751chat.com/RoomMake");
        }
        
        // GitHubへ移動
        private void btnSource_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("https://github.com/qu2/yamb");
        }

        // ProModeの切り替え
        private void cbPromode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPromode.Checked){
                DialogResult dr = MessageBox.Show("ProModeをオンにするとグレーアウトされた機能が開放されますが、予期せぬエラーが起こることがあります。それでもよろしければOKを押してください。", "yamb", MessageBoxButtons.OKCancel);

                // OKが押されたら
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    // 機能の開放
                    this.lnkLuvul.Enabled = true;
                    this.tsmiTroll.Enabled = true;

                    // ProModeの固定化
                    this.cbPromode.Enabled = false;
                }

                // キャンセルが押されたら
                else if (dr == System.Windows.Forms.DialogResult.Cancel)
                {
                    // チェックボックスを外す
                    this.cbPromode.Checked = false;
                }

                // それ以外が押されたら
                else
                {
                    // 同上
                    this.cbPromode.Checked = false;
                }
            }
        }
    }
}
