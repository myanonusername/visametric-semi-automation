namespace VisaMetric
{
    partial class BrowserForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserForm));
            this.browser = new CefSharp.WinForms.ChromiumWebBrowser();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnPersonalInfo = new System.Windows.Forms.Button();
            this.btnNationality = new System.Windows.Forms.Button();
            this.btnMeetingDetails = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnEditNationality = new System.Windows.Forms.Button();
            this.btnEditMeeting = new System.Windows.Forms.Button();
            this.btnEditPersonalInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browser
            // 
            this.browser.ActivateBrowserOnCreation = false;
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(0, 0);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(669, 488);
            this.browser.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.browser);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnEditPersonalInfo);
            this.splitContainer1.Panel2.Controls.Add(this.btnEditMeeting);
            this.splitContainer1.Panel2.Controls.Add(this.btnEditNationality);
            this.splitContainer1.Panel2.Controls.Add(this.btnPersonalInfo);
            this.splitContainer1.Panel2.Controls.Add(this.btnNationality);
            this.splitContainer1.Panel2.Controls.Add(this.btnMeetingDetails);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxUrl);
            this.splitContainer1.Panel2.Controls.Add(this.startBtn);
            this.splitContainer1.Size = new System.Drawing.Size(941, 488);
            this.splitContainer1.SplitterDistance = 669;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnPersonalInfo
            // 
            this.btnPersonalInfo.Location = new System.Drawing.Point(40, 252);
            this.btnPersonalInfo.Name = "btnPersonalInfo";
            this.btnPersonalInfo.Size = new System.Drawing.Size(126, 38);
            this.btnPersonalInfo.TabIndex = 2;
            this.btnPersonalInfo.Text = "اطلاعات شخصی";
            this.btnPersonalInfo.UseVisualStyleBackColor = true;
            this.btnPersonalInfo.Click += new System.EventHandler(this.btnPersonalInfo_Click);
            // 
            // btnNationality
            // 
            this.btnNationality.Location = new System.Drawing.Point(40, 139);
            this.btnNationality.Name = "btnNationality";
            this.btnNationality.Size = new System.Drawing.Size(126, 38);
            this.btnNationality.TabIndex = 2;
            this.btnNationality.Text = "ملیت";
            this.btnNationality.UseVisualStyleBackColor = true;
            this.btnNationality.Click += new System.EventHandler(this.btnNationality_Click);
            // 
            // btnMeetingDetails
            // 
            this.btnMeetingDetails.Location = new System.Drawing.Point(40, 194);
            this.btnMeetingDetails.Name = "btnMeetingDetails";
            this.btnMeetingDetails.Size = new System.Drawing.Size(126, 38);
            this.btnMeetingDetails.TabIndex = 2;
            this.btnMeetingDetails.Text = "جزییات ملاقات";
            this.btnMeetingDetails.UseVisualStyleBackColor = true;
            this.btnMeetingDetails.Click += new System.EventHandler(this.btnMeetingDetails_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(15, 12);
            this.textBoxUrl.Multiline = true;
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.ReadOnly = true;
            this.textBoxUrl.Size = new System.Drawing.Size(174, 33);
            this.textBoxUrl.TabIndex = 1;
            this.textBoxUrl.Visible = false;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(40, 84);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(126, 38);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "شروع";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnEditNationality
            // 
            this.btnEditNationality.Location = new System.Drawing.Point(186, 139);
            this.btnEditNationality.Name = "btnEditNationality";
            this.btnEditNationality.Size = new System.Drawing.Size(38, 38);
            this.btnEditNationality.TabIndex = 3;
            this.btnEditNationality.Text = "⚙";
            this.btnEditNationality.UseVisualStyleBackColor = true;
            this.btnEditNationality.Click += new System.EventHandler(this.btnEditNationality_Click);
            // 
            // btnEditMeeting
            // 
            this.btnEditMeeting.Location = new System.Drawing.Point(186, 194);
            this.btnEditMeeting.Name = "btnEditMeeting";
            this.btnEditMeeting.Size = new System.Drawing.Size(38, 38);
            this.btnEditMeeting.TabIndex = 3;
            this.btnEditMeeting.Text = "⚙";
            this.btnEditMeeting.UseVisualStyleBackColor = true;
            this.btnEditMeeting.Click += new System.EventHandler(this.btnEditMeeting_Click);
            // 
            // btnEditPersonalInfo
            // 
            this.btnEditPersonalInfo.Location = new System.Drawing.Point(186, 252);
            this.btnEditPersonalInfo.Name = "btnEditPersonalInfo";
            this.btnEditPersonalInfo.Size = new System.Drawing.Size(38, 38);
            this.btnEditPersonalInfo.TabIndex = 3;
            this.btnEditPersonalInfo.Text = "⚙";
            this.btnEditPersonalInfo.UseVisualStyleBackColor = true;
            this.btnEditPersonalInfo.Click += new System.EventHandler(this.btnEditPersonalInfo_Click);
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 488);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrowserForm";
            this.Text = "Browser Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CefSharp.WinForms.ChromiumWebBrowser browser;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Button btnMeetingDetails;
        private System.Windows.Forms.Button btnPersonalInfo;
        private System.Windows.Forms.Button btnNationality;
        private System.Windows.Forms.Button btnEditPersonalInfo;
        private System.Windows.Forms.Button btnEditMeeting;
        private System.Windows.Forms.Button btnEditNationality;
    }
}

