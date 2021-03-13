namespace IceBurn_simulator
{
    partial class updateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateForm));
            this.update_info_box = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_updateNow = new System.Windows.Forms.Button();
            this.btn_remindNextTime = new System.Windows.Forms.Button();
            this.btn_nerverRemind = new System.Windows.Forms.Button();
            this.update_info_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // update_info_box
            // 
            this.update_info_box.Controls.Add(this.label1);
            this.update_info_box.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.update_info_box.Location = new System.Drawing.Point(18, 13);
            this.update_info_box.Margin = new System.Windows.Forms.Padding(4);
            this.update_info_box.Name = "update_info_box";
            this.update_info_box.Padding = new System.Windows.Forms.Padding(4);
            this.update_info_box.Size = new System.Drawing.Size(365, 286);
            this.update_info_box.TabIndex = 5;
            this.update_info_box.TabStop = false;
            this.update_info_box.Text = "版本資訊";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 5;
            // 
            // btn_updateNow
            // 
            this.btn_updateNow.Enabled = false;
            this.btn_updateNow.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_updateNow.Location = new System.Drawing.Point(267, 306);
            this.btn_updateNow.Name = "btn_updateNow";
            this.btn_updateNow.Size = new System.Drawing.Size(116, 30);
            this.btn_updateNow.TabIndex = 6;
            this.btn_updateNow.Text = "立即更新";
            this.btn_updateNow.UseVisualStyleBackColor = true;
            this.btn_updateNow.Click += new System.EventHandler(this.btn_updateNow_Click);
            // 
            // btn_remindNextTime
            // 
            this.btn_remindNextTime.Enabled = false;
            this.btn_remindNextTime.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_remindNextTime.Location = new System.Drawing.Point(140, 306);
            this.btn_remindNextTime.Name = "btn_remindNextTime";
            this.btn_remindNextTime.Size = new System.Drawing.Size(121, 30);
            this.btn_remindNextTime.TabIndex = 7;
            this.btn_remindNextTime.Text = "略過此次更新";
            this.btn_remindNextTime.UseVisualStyleBackColor = true;
            this.btn_remindNextTime.Click += new System.EventHandler(this.btn_remindNextTime_Click);
            // 
            // btn_nerverRemind
            // 
            this.btn_nerverRemind.Enabled = false;
            this.btn_nerverRemind.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_nerverRemind.Location = new System.Drawing.Point(18, 306);
            this.btn_nerverRemind.Name = "btn_nerverRemind";
            this.btn_nerverRemind.Size = new System.Drawing.Size(116, 30);
            this.btn_nerverRemind.TabIndex = 8;
            this.btn_nerverRemind.Text = "永不提醒";
            this.btn_nerverRemind.UseVisualStyleBackColor = true;
            this.btn_nerverRemind.Click += new System.EventHandler(this.btn_nerverRemind_Click);
            // 
            // updateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 348);
            this.Controls.Add(this.btn_nerverRemind);
            this.Controls.Add(this.btn_remindNextTime);
            this.Controls.Add(this.btn_updateNow);
            this.Controls.Add(this.update_info_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "updateForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "檢查更新";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.updateForm_Load);
            this.Shown += new System.EventHandler(this.updateForm_Shown);
            this.update_info_box.ResumeLayout(false);
            this.update_info_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox update_info_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_updateNow;
        private System.Windows.Forms.Button btn_remindNextTime;
        private System.Windows.Forms.Button btn_nerverRemind;
    }
}