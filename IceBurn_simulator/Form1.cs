using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Media;
using System.IO;
using System.Net;


namespace IceBurn_simulator
{
    public partial class Form1 : Form
    {
        Form2 f2;
        public Form1()
        {
            InitializeComponent();

            //檢查更新
            Cheak_update();
            //media音量設定
            axWindowsMediaPlayer1.settings.volume = 15;
            //啟用動畫、使用台數初始化
            ani_checkBox.Checked = true;
            useNum_textBox.Text = "1";
            //輸入事件設定
            useNum_textBox.KeyPress += new KeyPressEventHandler(Usenum_KeyPress);
            //form2初始化
            this.LocationChanged += new EventHandler(Form1_LocationChanged);            
            f2 = new Form2();
            f2.Owner = this;
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = new Point(this.Right, this.Top);
            f2.Height = this.Height;
            f2.Show();

            ReadIDsByTXT();
        }
        void Form1_LocationChanged(object sender, EventArgs e)
        {
            if (f2 != null)
                f2.Location = new Point(this.Right, this.Top);
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.PlayStateChange += player_PlayStateChange;
        }


        //---------------------檢查更新---------------------------------------
        bool cheakUpdate = false;
        bool nextTime = false;
        string remindedVersion = "";
        string lastVersion = "" , nowVersion = "";
        private void Cheak_update()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "data/updateSetting.txt";
            string[] lines = System.IO.File.ReadAllLines(@path);
            foreach(string line in lines){
                string[] words = line.Split('=');
                if (words[0] == "cheakUpdate")
                    cheakUpdate = bool.Parse(words[1]);
                if (words[0] == "nexttime")
                    nextTime = bool.Parse(words[1]);
                if (words[0] == "remindedversion")
                    remindedVersion = words[1].Replace(".", "");
            }                        
            string uriPath = AppDomain.CurrentDomain.BaseDirectory + "data/cheakURI.txt";
            string cheakURI = File.ReadAllText(@uriPath, Encoding.UTF8);
            DownloadStreamString(cheakURI);            
        }

        public void DownloadStreamString(string url)
        {
            try
            {
                WebClient wc = new WebClient();
                wc.DownloadFileCompleted += update_DownloadFileCompleted;
                wc.DownloadFileAsync(new Uri(url), "data/updateinfo.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("獲取更新資訊失敗，將於下次開啟時重新獲取資訊。" + "\r\n" + ex.Message, "錯誤");
            }
        }

        string[] updateInfo;
        private void update_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            updateInfo = File.ReadAllLines("data/updateinfo.txt", Encoding.UTF8);
            if(updateInfo.Length != 0)
            {
                lastVersion = updateInfo[0].Replace(".", "");
                nowVersion = nowVersion = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "version.txt", Encoding.UTF8).Replace("\n", "").Replace(" ", "").Replace("\t", "").Replace("\r", "").Replace(".", "");
                if (int.Parse(nowVersion) < int.Parse(lastVersion))
                {
                    if (cheakUpdate || right_click)
                    {
                        updateForm f3 = new updateForm();
                        f3.Show();
                        right_click = false;
                    }
                    else if (nextTime)
                    {
                        if (int.Parse(remindedVersion) < int.Parse(lastVersion))
                        {
                            updateForm f3 = new updateForm();
                            f3.Show();
                        }
                        else
                            File.Delete("data/updateinfo.txt");
                    }
                    else
                        File.Delete("data/updateinfo.txt");
                }
                else
                {
                    if (right_click)
                    {
                        MessageBox.Show("目前的版本與伺服器相同或更新。", "檢查更新");
                    }
                    File.Delete("data/updateinfo.txt");
                }
            }                
        }

        bool right_click = false;
        private void 檢查更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            right_click = true;
            Cheak_update();
        }

        //---------------------按鍵事件設定---------------------------------------
        private void Usenum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                {
                    e.Handled = true;
                }
            }
            if (e.KeyChar == (char)Keys.Return)
            {
                Play_clickSound();
                if (burning == false)
                {
                    Task.Delay(10);
                    burning = true;
                    ani_checkBox.Enabled = false;
                    useNum_textBox.Enabled = false;
                    if (ani_Enable == true)
                    {
                        Image myimage = new Bitmap(@"img\burn\2.gif");
                        pictureBox1.Image = myimage;
                        timer1.Enabled = true;
                    }
                    else
                        Lottery();
                }
            }
            useNum_textBox.Focus();
        }

        //對確認按鈕按下Enter
        private void btn_cheak_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Play_clickSound();
                if (burning == false)
                {
                    Task.Delay(10);
                    burning = true;
                    ani_checkBox.Enabled = false;
                    useNum_textBox.Enabled = false;
                    if (ani_Enable == true)
                    {
                        Image myimage = new Bitmap(@"img\burn\2.gif");
                        pictureBox1.Image = myimage;
                        timer1.Enabled = true;
                    }
                    else
                        Lottery();
                }
            }
            btn_cheak.Focus();
        }

        //對取消按鈕按下Enter
        private void btn_cancel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Play_clickSound();
                if (burning == true)
                {
                    Task.Delay(10);
                    Image myimage = new Bitmap(@"img\before\before.gif");
                    pictureBox1.Image = myimage;
                    sec = 0;
                    timer1.Enabled = false;
                    ani_checkBox.Enabled = true;
                    useNum_textBox.Enabled = true;
                    burning = false;
                }
            }
        }

        //對關閉按鈕按下Enter
        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Play_clickSound();
                if (burning == false)
                {
                    Task.Delay(10);
                    exit = true;
                }
            }
        }

        //對啟用動畫按下Enter
        private void ani_checkBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (ani_checkBox.Checked == true)
                    ani_Enable = true;
                else
                    ani_Enable = false;
            }                
        }


        //----------------------移動視窗------------------------------------------------
        private Point mPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }


        //--------------------圓角-------------------------------------------------
        public void SetWindowRegion()
        {
            System.Drawing.Drawing2D.GraphicsPath FormPath;
            FormPath = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            FormPath = GetRoundedRectPath(rect, 16);
            this.Region = new Region(FormPath);
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();
            //   左上角   
            path.AddArc(arcRect, 180, 90);
            //   右上角   
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);
            //   右下角   
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);
            //   左下角   
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnResize(System.EventArgs e)
        {
            this.Region = null;
            SetWindowRegion();
        }


        //--------------------按鈕變化----------------------------------
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"img\btn\btn5.png");
            button1.BackgroundImage = myimage;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"img\btn\btn4.png");
            button1.BackgroundImage = myimage;
        }

        private void btn_cheak_MouseEnter(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"img\btn\btn1.png");
            btn_cheak.BackgroundImage = myimage;
        }

        private void btn_cheak_MouseLeave(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"img\btn\btn0.png");
            btn_cheak.BackgroundImage = myimage;            
        }

        private void btn_cancel_MouseEnter(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"img\btn\btn3.png");
            btn_cancel.BackgroundImage = myimage;
        }

        private void btn_cancel_MouseLeave(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"img\btn\btn2.png");
            btn_cancel.BackgroundImage = myimage;
        }


        //---------------------按鈕按下-------------------------------------        
        private void Play_clickSound()
        {
            this.axWindowsMediaPlayer1.URL = string.Format(@"aud\X2_Button_Mouse_Up.wav");
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btn_cheak_Click(object sender, EventArgs e)
        {
        }

        bool burning = false;
        private void btn_cheak_MouseUp_1(object sender, MouseEventArgs e)
        {
            Play_clickSound();
            if (burning == false)
            {
                Task.Delay(10);
                burning = true;
                ani_checkBox.Enabled = false;
                useNum_textBox.Enabled = false;
                if (ani_Enable == true)
                {
                    Image myimage = new Bitmap(@"img\burn\2.gif");
                    pictureBox1.Image = myimage;
                    timer1.Enabled = true;
                }
                else
                    Lottery();
            }            
        }

        private void btn_cancel_MouseUp(object sender, MouseEventArgs e)
        {
            Play_clickSound();
            if (burning == true)
            {                
                Task.Delay(10);
                Image myimage = new Bitmap(@"img\before\before.gif");
                pictureBox1.Image = myimage;
                sec = 0;
                timer1.Enabled = false;
                ani_checkBox.Enabled = true;
                useNum_textBox.Enabled = true;
                burning = false;
            }
        }

        bool exit = false;
        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            Play_clickSound();
            if (burning == false)
            {
                Task.Delay(10);
                exit = true;
            }
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped && exit == true)
            {
                System.Environment.Exit(0);
            }
        }


        //--------------------計時切換動畫-------------------------------------------
        int sec = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec += 1000;
            if(sec == 10000)
            {
                Image myimage = new Bitmap(@"img\before\before.gif");
                pictureBox1.Image = myimage;
                sec = 0;                
                timer1.Enabled = false;
                Lottery();                
            }
        }


        //----------------------啟用動畫-----------------------------------------
        bool ani_Enable = true;
        private void ani_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ani_checkBox.Checked == true)
                ani_Enable = true;            
            else
                ani_Enable = false;            
        }


        //----------------------抽出物品---------------------------------------        
        int rand_Num = 0;
        List<string> name_list = new List<string>();
        private void Lottery()
        {
            int use_Num;
            if (useNum_textBox.Text != "")
                use_Num = Int32.Parse(useNum_textBox.Text);
            else
                use_Num = 1;

            
            
            var rand = new Random();            
            for (int i = 0; i < use_Num; i++)
            {
                int getNum = 1;
                rand_Num = rand.Next(total) + 1;
                int index = Array.FindIndex(lott_list, GetNameIdex);
                int list_index = name_list.FindIndex(x => x.Contains(name[index]));
                if (list_index >= 0)
                {
                    string[] words = (name_list[list_index]).ToString().Split('X');
                    getNum = Int32.Parse(words[1]);
                    getNum++;
                    name_list.Remove(name_list[list_index]);
                }
                name_list.Add(name[index] + " X" + getNum);
            }

            //傳送給Form2
            f2.list_clear();
            for (int i = 0; i < name_list.Count; i++)
            {
                f2.String1 = name_list[i];
                f2.SetValue();
            }

            ani_checkBox.Enabled = true;
            useNum_textBox.Enabled = true;
            burning = false;
        }

        private bool GetNameIdex(decimal s)
        {
            if (decimal.ToInt32(s) >= rand_Num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void namelist_clear()
        {
            name_list.Clear();
        }


        //----------------------讀取機率表---------------------------------------     
        string[] lines;
        string[] name;
        decimal[] varlues;
        private void ReadIDsByTXT()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Probability.txt";
            if (System.IO.File.Exists(path))
            {
                lines = System.IO.File.ReadAllLines(@path);
                name = new string[lines.Length];
                varlues = new decimal[lines.Length];
                int k = 0;
                foreach (string line in lines)
                {
                    string[] words = line.Split('=');
                    name[k] = words[0];
                    varlues[k] = decimal.Parse(words[1]);
                    k++;
                }
            }
            Lottery_list();
        }


        //----------------------列出抽籤表---------------------------------------        
        decimal[] lott_list;
        int total = 0;
        private void Lottery_list()
        {            
            decimal 倍率 = varlues[Array.IndexOf(name, "倍率")];
            lott_list = new decimal[varlues.Length];

            foreach(string j in name)
            {
                if(j != "倍率" && j != "")
                {   
                    if(Array.IndexOf(name, j) != 0)
                        lott_list[Array.IndexOf(name, j)] = lott_list[Array.IndexOf(name, j)-1] + (varlues[Array.IndexOf(name, j)] * 倍率);
                    else
                        lott_list[Array.IndexOf(name, j)] = lott_list[Array.IndexOf(name, j)] + (varlues[Array.IndexOf(name, j)] * 倍率);
                    Console.WriteLine(lott_list[Array.IndexOf(name, j)]);
                }
            }
            total = Decimal.ToInt32(lott_list[(lott_list.Length-2)]);
        }        
    }
}
