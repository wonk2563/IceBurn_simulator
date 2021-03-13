namespace IceBurn_simulator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cheak = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.useNum_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ani_checkBox = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.檢查更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(756, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 38);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button1_KeyUp);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // btn_cheak
            // 
            this.btn_cheak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cheak.BackgroundImage")));
            this.btn_cheak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cheak.Location = new System.Drawing.Point(246, 720);
            this.btn_cheak.Name = "btn_cheak";
            this.btn_cheak.Size = new System.Drawing.Size(165, 56);
            this.btn_cheak.TabIndex = 1;
            this.btn_cheak.UseVisualStyleBackColor = true;
            this.btn_cheak.Click += new System.EventHandler(this.btn_cheak_Click);
            this.btn_cheak.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn_cheak_KeyUp);
            this.btn_cheak.MouseEnter += new System.EventHandler(this.btn_cheak_MouseEnter);
            this.btn_cheak.MouseLeave += new System.EventHandler(this.btn_cheak_MouseLeave);
            this.btn_cheak.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_cheak_MouseUp_1);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancel.BackgroundImage")));
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(417, 720);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(165, 56);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn_cancel_KeyUp);
            this.btn_cancel.MouseEnter += new System.EventHandler(this.btn_cancel_MouseEnter);
            this.btn_cancel.MouseLeave += new System.EventHandler(this.btn_cancel_MouseLeave);
            this.btn_cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseUp);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(632, 708);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(146, 45);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(213, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 571);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(497, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "使用";
            // 
            // useNum_textBox
            // 
            this.useNum_textBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.useNum_textBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.useNum_textBox.Location = new System.Drawing.Point(555, 14);
            this.useNum_textBox.MaxLength = 65565;
            this.useNum_textBox.Name = "useNum_textBox";
            this.useNum_textBox.Size = new System.Drawing.Size(100, 34);
            this.useNum_textBox.TabIndex = 6;
            this.useNum_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(661, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "台";
            // 
            // ani_checkBox
            // 
            this.ani_checkBox.AutoSize = true;
            this.ani_checkBox.BackColor = System.Drawing.Color.Transparent;
            this.ani_checkBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ani_checkBox.Location = new System.Drawing.Point(318, 19);
            this.ani_checkBox.Name = "ani_checkBox";
            this.ani_checkBox.Size = new System.Drawing.Size(114, 29);
            this.ani_checkBox.TabIndex = 7;
            this.ani_checkBox.Text = "啟用動畫";
            this.ani_checkBox.UseVisualStyleBackColor = false;
            this.ani_checkBox.CheckedChanged += new System.EventHandler(this.ani_checkBox_CheckedChanged);
            this.ani_checkBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ani_checkBox_KeyUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檢查更新ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 28);
            // 
            // 檢查更新ToolStripMenuItem
            // 
            this.檢查更新ToolStripMenuItem.Name = "檢查更新ToolStripMenuItem";
            this.檢查更新ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.檢查更新ToolStripMenuItem.Text = "檢查更新";
            this.檢查更新ToolStripMenuItem.Click += new System.EventHandler(this.檢查更新ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 786);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.ani_checkBox);
            this.Controls.Add(this.useNum_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_cheak);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ice_Burner_Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_cheak;
        private System.Windows.Forms.Button btn_cancel;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox useNum_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ani_checkBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檢查更新ToolStripMenuItem;
    }
}

