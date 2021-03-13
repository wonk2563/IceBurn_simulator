using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace IceBurn_simulator
{
    public partial class updateForm : Form
    {
        public updateForm()
        {
            InitializeComponent();
        }
        private void updateForm_Load(object sender, EventArgs e)
        {                       
        }
        private void updateForm_Shown(object sender, EventArgs e)
        {
            ReadVersionByTXT();
            ReadVersion();
        }

        string appPath = AppDomain.CurrentDomain.BaseDirectory;
        string nowVersion = "", cheakURI = "";
        private void ReadVersionByTXT()
        {
            string path = appPath + "version.txt";
            string uriPath = appPath + "data/cheakURI.txt";
            if (System.IO.File.Exists(path))
            {
                nowVersion = File.ReadAllText(@path, Encoding.UTF8).Replace("\n", "").Replace(" ", "").Replace("\t", "").Replace("\r", "");
                Console.WriteLine(nowVersion);
            }
            else
            {
                MessageBox.Show("無法獲取當前版本資訊", "錯誤");
            }

            if (System.IO.File.Exists(uriPath))
            {
                cheakURI = File.ReadAllText(@uriPath, Encoding.UTF8);
            }
            else
            {
                MessageBox.Show("無法獲取更新資訊", "錯誤");
            }
        }

        string[] updateInfo, fixInfo;
        string lastVersion = "";
        string[] updateSetting = new string[3];
        string path = AppDomain.CurrentDomain.BaseDirectory + "data/updateSetting.txt";        
        private void btn_updateNow_Click(object sender, EventArgs e)
        {
            ProcessStartInfo Info = new ProcessStartInfo();
            Info.FileName = "update.exe"; //執行的檔案名稱
            Info.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory; //檔案所在的目錄
            Process.Start(Info);
            Thread.Sleep(10);
            Application.Exit();
        }

        private void btn_remindNextTime_Click(object sender, EventArgs e)
        {            
            updateSetting[0] = "cheakUpdate=false";
            updateSetting[1] = "nexttime=true";
            updateSetting[2] = "remindedversion=" + lastVersion;
            File.WriteAllLines(@path, updateSetting);
            this.Close();
        }        

        private void btn_nerverRemind_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@path);
            int i = 0;
            foreach (string line in lines)
            {
                updateSetting[i] = line;
                i++;
            }
            updateSetting[0] = "cheakUpdate=false";
            updateSetting[1] = "nexttime=false";
            File.WriteAllLines(@path, updateSetting);
            this.Close();
        }

        /*public void DownloadStreamString(string url)
        {
            try
            {
                WebClient wc = new WebClient();
                wc.DownloadFileCompleted += update_DownloadFileCompleted;
                wc.DownloadFileAsync(new Uri(url), "data/updateinfo.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("獲取更新資訊失敗" + "\r\n" + ex.Message, "錯誤");
                Application.Exit();
            }
        }*/

        private void ReadVersion()
        {
            updateInfo = File.ReadAllLines("data/updateinfo.txt", Encoding.UTF8);
            if(updateInfo.Length != 0)
            {
                string fix = "";
                lastVersion = updateInfo[0];
                if (updateInfo.Length - 3 > 0)
                {
                    fixInfo = new string[updateInfo.Length - 3];
                    for (int i = 0; i < updateInfo.Length - 3; i++)
                        fixInfo[i] = updateInfo[i + 2];
                    fix = String.Join("\n", fixInfo);
                }
                if (fix == "")
                    fix = "無";

                if (int.Parse(nowVersion.Replace(".", "")) < int.Parse(lastVersion.Replace(".", "")))
                {
                    label1.Text = $"\n目前版本：{nowVersion}　更新版本：{lastVersion}\n\n" +
                       $"更新內容：\n" +
                       $"{fix}\n\n";
                }
                else
                {
                    this.Close();
                }
                File.Delete("data/updateinfo.txt");
                string[] lines = System.IO.File.ReadAllLines(@path);
                int k = 0;
                foreach (string line in lines)
                {
                    updateSetting[k] = line;
                    k++;
                }
                updateSetting[0] = "cheakUpdate=true";
                updateSetting[1] = "nexttime=false";
                File.WriteAllLines(@path, updateSetting);
                btn_nerverRemind.Enabled = true;
                btn_remindNextTime.Enabled = true;
                btn_updateNow.Enabled = true;
            }
            else
                MessageBox.Show("獲取更新資訊失敗" + "\r\n請檢查網路是否正常", "錯誤");
        }
    }
}
