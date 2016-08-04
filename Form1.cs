/* yamb (yet another minakoi browser) code by @Lv470 */
/* ver 1.0.1 */

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
        }

        // 題名の表示
        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string formTitle;
            formTitle = (" - " + browser.DocumentTitle);
            this.Text = ("yamb" + formTitle);
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

        // トップに戻る（ミナコイ時）
        private void btnTop_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://www.3751chat.com/");
        }

        // トップに戻る（ルブル時）
        private void btnTop_L_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://chat.luvul.net/");
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
        private void btnSS_Click(object sender, EventArgs e)
        {
            string random = Guid.NewGuid().ToString("N").Substring(0, 4);

            Rectangle rc = Screen.PrimaryScreen.Bounds;
            Bitmap bmp = new Bitmap(rc.Width, rc.Height, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(rc.X, rc.Y, 0, 0, rc.Size, CopyPixelOperation.SourceCopy);
            }
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\"+ random + "SS.bmp";
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

        // 小学生ルームへ移動
        private void lnkEss_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://www.3751chat.com/ChatRoom?room_id=72111");
        }

        // 10代ルームへ移動
        private void lnk10_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://www.3751chat.com/ChatRoom?room_id=5");
        }

        // 20代ルームへ移動
        private void lnk20_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://www.3751chat.com/ChatRoom?room_id=7");
        }

        // ルブルへ移動
        private void lnkLuvul_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://chat.luvul.net/");
            // 警告
            MessageBox.Show("ルブルチャットではyambの一部機能が正常に動作しないことがあります。", "yamb");

            // Topボタンの切り替え
            this.btnTop.Visible = false;
            this.btnTop_L.Visible = true;

            // ルーム作成ボタンの切り替え
            this.roomMake2.Visible = true;
            this.roomMake.Visible = false;
        }

        // ミナコイトップへ移動
        private void minakoiTop_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://www.3751chat.com/");

            // Topボタンの切り替え
            this.btnTop.Visible = true;
            this.btnTop_L.Visible = false;

            // ルーム作成ボタンの切り替え
            this.roomMake2.Visible = false;
            this.roomMake.Visible = true;
        }

        // ページ移動(yamb/Developers) 
        private void dev_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        // 連投
        // なぜかi=10の時しか実行されない
        // ＿人人人人人人人人人＿
        // ＞　 いい加減動け　 ＜
        // ￣Y^Y^Y^Y^Y^Y^Y^Y^Y￣
        private void bakugeki_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 10) {
                // 待機時間を入れないと動作しないかもしれない
                // 入れたら入れたで固まったようになる
                // そもそも入れる場所はここでいいのだろうか
                // (ﾟДﾟ)＜死ね
                System.Threading.Thread.Sleep(1000);

                string random = Guid.NewGuid().ToString("N").Substring(0, 4);

                HtmlElementCollection all = browser.Document.All;
                HtmlElementCollection forms = all.GetElementsByName("chat");
                forms[0].InnerText += ("Hello(" + random + i.ToString() + (")"));

                // 必要かも？
                /* MessageBox.Show(i.ToString());
                SendKeys.Send("{ENTER}");

                this.Activate(); */

                // やけくそ
                SendKeys.Send("{ENTER}");
                // どうにでもなれ
                HtmlElementCollection form = browser.Document.GetElementsByTagName("form");
                form[0].InvokeMember("submit");

                i++;
            }
        }

        // 駐屯
        // ループ処理未実装 誰かループ処理つけてください(土下座)
        // こっちは旧コード
        private void stay_Click(object sender, EventArgs e)
        {
            string random = Guid.NewGuid().ToString("N").Substring(0, 4);

            HtmlElementCollection all = browser.Document.All;
            HtmlElementCollection forms = all.GetElementsByName("chat");
            forms[0].InnerText = ("Hello(" + random + (")"));

            SendKeys.Send("{ENTER}");
        }

        // ミナコイルーム作成
        private void roomMake_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://www.3751chat.com/RoomMake");
        }

        // ルブルルーム作成
        private void roomMake2_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("http://chat.luvul.net/RoomMake");
        }

        // GitHubへ移動
        private void btnSource_Click(object sender, EventArgs e)
        {
            browser.Url = new Uri("https://github.com/qu2/yamb");
        }

        // enable beta
        private void cbPromode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPromode.Checked){
                DialogResult dr = MessageBox.Show("この機能を有効にすると通常使用できないテスト中の機能を使うことができるようになりますが、動作が不安定になったり正しく機能しない場合があります。それでも機能を有効にしますか？", "yamb", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                // OKが押されたら
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    // 機能の開放
                    this.lnkLuvul.Enabled = true;
                    this.tsmiTroll.Enabled = true;

                    // チェックボックスの固定化
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

        /* サイコロ */
        // 2d6
        private void dice_2d6_Click(object sender, EventArgs e)
        {
            HtmlElementCollection all = browser.Document.All;
            HtmlElementCollection forms = all.GetElementsByName("chat");
            forms[0].InnerText = ("2d6");
            SendKeys.Send("{ENTER}");
        }


        /* 定型文 */
        // こんにちは
        private void FP_Hello_Click(object sender, EventArgs e)
        {
            HtmlElementCollection all = browser.Document.All;
            HtmlElementCollection forms = all.GetElementsByName("chat");
            forms[0].InnerText = ("こんにちは");
            SendKeys.Send("{ENTER}");
        }

        // こんばんは
        private void FP_Evening_Click(object sender, EventArgs e)
        {
            HtmlElementCollection all = browser.Document.All;
            HtmlElementCollection forms = all.GetElementsByName("chat");
            forms[0].InnerText = ("こんばんは");
            SendKeys.Send("{ENTER}");
        }

        // ノシ
        private void FP_Bye_Click(object sender, EventArgs e)
        {
            HtmlElementCollection all = browser.Document.All;
            HtmlElementCollection forms = all.GetElementsByName("chat");
            forms[0].InnerText = ("ノシ");
            SendKeys.Send("{ENTER}");
        }
    }
}
