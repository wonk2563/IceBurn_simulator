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
using System.Drawing.Text;

namespace IceBurn_simulator
{
    public partial class Form2 : Form
    {        
        public Form2()
        {
            InitializeComponent();
            //media音量設定
            axWindowsMediaPlayer1.settings.volume = 15;
            button1.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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


        //--------------------------List1背景色----------------------------------------------------
        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();
                //字體顏色
                Brush myBrush = Brushes.Black; //前景色
                Color bgColor = Color.White;   //背景色

                //依照條件變更字體顏色
                if (listBox1.Items[e.Index].ToString().Contains("狂戰士") || listBox1.Items[e.Index].ToString().Contains("犧牲") || listBox1.Items[e.Index].ToString().Contains("勝利榮耀") || listBox1.Items[e.Index].ToString().Contains("賢者的魔法石箱(2個)")
                    || listBox1.Items[e.Index].ToString().Contains("武器專用強化符咒Lv.9") || listBox1.Items[e.Index].ToString().Contains("武器專用強化符咒Lv.10") || listBox1.Items[e.Index].ToString().Contains("防具專用強化符咒Lv.9") || listBox1.Items[e.Index].ToString().Contains("防具專用強化符咒Lv.10") || listBox1.Items[e.Index].ToString().Contains("強化的符咒Lv.8")
                    || listBox1.Items[e.Index].ToString().Contains("武器裝飾箱子") || listBox1.Items[e.Index].ToString().Contains("艾利亞諾德BOSS箱") || listBox1.Items[e.Index].ToString().Contains("巴尼米爾BOSS箱") || listBox1.Items[e.Index].ToString().Contains("利古魔爾BOSS箱") || listBox1.Items[e.Index].ToString().Contains("魔奇Boss箱子") || listBox1.Items[e.Index].ToString().Contains("艾德Boss箱子") || 
                    listBox1.Items[e.Index].ToString().Contains("貝斯馬Boss箱子") || listBox1.Items[e.Index].ToString().Contains("厄泰拉Boss箱子") || listBox1.Items[e.Index].ToString().Contains("沛塔Boss箱子") || listBox1.Items[e.Index].ToString().Contains("班德Boss箱子") || listBox1.Items[e.Index].ToString().Contains("哈梅爾Boss箱子") || listBox1.Items[e.Index].ToString().Contains("沙德BOSS箱") || 
                    listBox1.Items[e.Index].ToString().Contains("拉諾斯BOSS箱") || listBox1.Items[e.Index].ToString().Contains("艾里希溫BOSS箱") || listBox1.Items[e.Index].ToString().Contains("完全恢復藥水50個箱") || listBox1.Items[e.Index].ToString().Contains("完全恢復藥水箱(100個)"))                
                    myBrush = Brushes.Purple;

                if (listBox1.Items[e.Index].ToString().Contains("額外傷害特級魔法石") || listBox1.Items[e.Index].ToString().Contains("致命一擊特級魔法石") || listBox1.Items[e.Index].ToString().Contains("動作速度特級魔法石") || 
                    listBox1.Items[e.Index].ToString().Contains("傷害減少特級魔法石") || listBox1.Items[e.Index].ToString().Contains("極大化特級魔法石") || listBox1.Items[e.Index].ToString().Contains("HP特級魔法石") || listBox1.Items[e.Index].ToString().Contains("晉級時裝箱(7天)") || listBox1.Items[e.Index].ToString().Contains("鋼鐵製紡車捲線器") || listBox1.Items[e.Index].ToString().Contains("彩色木製浮標"))
                    myBrush = Brushes.Yellow;

                if (listBox1.Items[e.Index].ToString().Contains("武器箱") || listBox1.Items[e.Index].ToString().Contains("上衣箱") || listBox1.Items[e.Index].ToString().Contains("下衣箱") || listBox1.Items[e.Index].ToString().Contains("手套箱") || listBox1.Items[e.Index].ToString().Contains("鞋子箱")
                    || listBox1.Items[e.Index].ToString().Contains("髮型箱") || listBox1.Items[e.Index].ToString().Contains("帽子箱") || listBox1.Items[e.Index].ToString().Contains("飾品(下衣)箱") || listBox1.Items[e.Index].ToString().Contains("飾品(上衣)箱") || listBox1.Items[e.Index].ToString().Contains("皇冠箱") || listBox1.Items[e.Index].ToString().Contains("飾品(耳環)箱")  || listBox1.Items[e.Index].ToString().Contains("飾品(臉上)箱") || listBox1.Items[e.Index].ToString().Contains("飾品(臉中)箱") || listBox1.Items[e.Index].ToString().Contains("飾品(手臂)箱")
                    || listBox1.Items[e.Index].ToString().Contains("鬥志藥水") || listBox1.Items[e.Index].ToString().Contains("適應靈藥")
                    || listBox1.Items[e.Index].ToString().Contains("艾爾結晶(不明) 50個") || listBox1.Items[e.Index].ToString().Contains("艾爾結晶(火) 50個") || listBox1.Items[e.Index].ToString().Contains("艾爾結晶(水) 50個") || listBox1.Items[e.Index].ToString().Contains("艾爾結晶(風) 50個") || listBox1.Items[e.Index].ToString().Contains("艾爾結晶(地) 50個") || listBox1.Items[e.Index].ToString().Contains("艾爾結晶(闇) 50個") 
                    || listBox1.Items[e.Index].ToString().Contains("艾爾結晶(光) 50個") || listBox1.Items[e.Index].ToString().Contains("火之水晶球250入箱") || listBox1.Items[e.Index].ToString().Contains("自然之水晶球250入箱") || listBox1.Items[e.Index].ToString().Contains("水之水晶球250入箱") || listBox1.Items[e.Index].ToString().Contains("風之水晶球250入箱") || listBox1.Items[e.Index].ToString().Contains("光之水晶球250入箱") || listBox1.Items[e.Index].ToString().Contains("闇之水晶球250入箱"))
                    myBrush = Brushes.White;

                //背景顏色
                if (e.Index%2 == 1)
                {
                    bgColor = Color.LightSlateGray;
                }
                if (e.Index % 2 == 0)
                {
                    bgColor = Color.DarkGray;
                }
                //繪製背景
                e.Graphics.FillRectangle(new SolidBrush(bgColor), e.Bounds);
                //繪製文字
                e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
                //繪製聚焦框
                e.DrawFocusRectangle();
            }
        }


        //--------------------------從Form1接收資料----------------------------------------------------
        private string string1;
        public string String1
        {
            set
            {
                string1 = value;
            }
        }

        int totalGet = 0;
        public void SetValue()
        {          
            string[] words = string1.Split('X');
            totalGet = totalGet + Int32.Parse(words[1]);
            label1.Text = "已使用 " + totalGet + " 台";
            listBox1.Items.Add(string1);
        }
        public void list_clear()
        {
            totalGet = 0;
            listBox1.Items.Clear();
        }

        //--------------------------按鈕變化----------------------------------------------------
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"img\btn\clear2.png");
            button1.BackgroundImage = myimage;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"img\btn\clear.png");
            button1.BackgroundImage = myimage;
        }


        //--------------------------按鈕按下----------------------------------------------------
        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            Play_clickSound();
            listBox1.Items.Clear();
            ((Form1)this.Owner).namelist_clear();
            totalGet = 0;
            label1.Text = "已使用 " + totalGet + " 台";
        }
        private void Play_clickSound()
        {
            this.axWindowsMediaPlayer1.URL = string.Format(@"aud\X2_Button_Mouse_Up.wav");
        }


        //---------------------按鍵事件設定---------------------------------------
        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Play_clickSound();
                listBox1.Items.Clear();
                ((Form1)this.Owner).namelist_clear();
                totalGet = 0;
                label1.Text = "已使用 " + totalGet + " 台";
            }                
        }
    }
}
