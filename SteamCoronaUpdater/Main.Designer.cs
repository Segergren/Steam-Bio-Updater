namespace SteamCoronaUpdater
{
    partial class Updater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updater));
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.Togglebtn = new System.Windows.Forms.Button();
            this.BioUpdater = new System.Windows.Forms.Timer(this.components);
            this.closebtn = new System.Windows.Forms.PictureBox();
            this.hidebtn = new System.Windows.Forms.PictureBox();
            this.usernametbx = new System.Windows.Forms.TextBox();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.passwordtbx = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.loggedInTimer = new System.Windows.Forms.Timer(this.components);
            this.loggedInPanel = new System.Windows.Forms.Panel();
            this.ShowFormat = new System.Windows.Forms.Button();
            this.characterCounter = new System.Windows.Forms.Label();
            this.biotbx = new System.Windows.Forms.TextBox();
            this.Biolbl = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.loggedInPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Browser
            // 
            this.Browser.Location = new System.Drawing.Point(535, 301);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.ScriptErrorsSuppressed = true;
            this.Browser.Size = new System.Drawing.Size(20, 20);
            this.Browser.TabIndex = 0;
            this.Browser.Url = new System.Uri("https://steamcommunity.com/my", System.UriKind.Absolute);
            this.Browser.Visible = false;
            this.Browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Browser_DocumentCompleted);
            // 
            // Togglebtn
            // 
            this.Togglebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Togglebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Togglebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(59)))), ((int)(((byte)(212)))));
            this.Togglebtn.Location = new System.Drawing.Point(141, 212);
            this.Togglebtn.Name = "Togglebtn";
            this.Togglebtn.Size = new System.Drawing.Size(149, 47);
            this.Togglebtn.TabIndex = 1;
            this.Togglebtn.Text = "Start";
            this.Togglebtn.UseVisualStyleBackColor = false;
            this.Togglebtn.Click += new System.EventHandler(this.Togglebtn_Click);
            // 
            // BioUpdater
            // 
            this.BioUpdater.Interval = 1000;
            this.BioUpdater.Tick += new System.EventHandler(this.BioUpdater_Tick);
            // 
            // closebtn
            // 
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.Image = ((System.Drawing.Image)(resources.GetObject("closebtn.Image")));
            this.closebtn.Location = new System.Drawing.Point(532, 3);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(32, 32);
            this.closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closebtn.TabIndex = 3;
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // hidebtn
            // 
            this.hidebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidebtn.Image = ((System.Drawing.Image)(resources.GetObject("hidebtn.Image")));
            this.hidebtn.Location = new System.Drawing.Point(494, 3);
            this.hidebtn.Name = "hidebtn";
            this.hidebtn.Size = new System.Drawing.Size(32, 32);
            this.hidebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hidebtn.TabIndex = 4;
            this.hidebtn.TabStop = false;
            this.hidebtn.Click += new System.EventHandler(this.Hidebtn_Click);
            // 
            // usernametbx
            // 
            this.usernametbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(59)))), ((int)(((byte)(212)))));
            this.usernametbx.Location = new System.Drawing.Point(187, 63);
            this.usernametbx.Name = "usernametbx";
            this.usernametbx.Size = new System.Drawing.Size(192, 26);
            this.usernametbx.TabIndex = 5;
            // 
            // usernamelbl
            // 
            this.usernamelbl.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(59)))), ((int)(((byte)(212)))));
            this.usernamelbl.Location = new System.Drawing.Point(187, 29);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(192, 31);
            this.usernamelbl.TabIndex = 6;
            this.usernamelbl.Text = "Username";
            this.usernamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordlbl
            // 
            this.passwordlbl.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(59)))), ((int)(((byte)(212)))));
            this.passwordlbl.Location = new System.Drawing.Point(187, 103);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(192, 31);
            this.passwordlbl.TabIndex = 8;
            this.passwordlbl.Text = "Password";
            this.passwordlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordtbx
            // 
            this.passwordtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(59)))), ((int)(((byte)(212)))));
            this.passwordtbx.Location = new System.Drawing.Point(187, 137);
            this.passwordtbx.Name = "passwordtbx";
            this.passwordtbx.Size = new System.Drawing.Size(192, 26);
            this.passwordtbx.TabIndex = 7;
            this.passwordtbx.UseSystemPasswordChar = true;
            // 
            // loginbtn
            // 
            this.loginbtn.Enabled = false;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(59)))), ((int)(((byte)(212)))));
            this.loginbtn.Location = new System.Drawing.Point(209, 180);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(149, 35);
            this.loginbtn.TabIndex = 9;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(3, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(178, 50);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 10;
            this.Logo.TabStop = false;
            this.Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Logo_MouseDown);
            // 
            // loggedInTimer
            // 
            this.loggedInTimer.Enabled = true;
            this.loggedInTimer.Interval = 1000;
            this.loggedInTimer.Tick += new System.EventHandler(this.LoggedInTimer_Tick);
            // 
            // loggedInPanel
            // 
            this.loggedInPanel.Controls.Add(this.ShowFormat);
            this.loggedInPanel.Controls.Add(this.characterCounter);
            this.loggedInPanel.Controls.Add(this.biotbx);
            this.loggedInPanel.Controls.Add(this.Biolbl);
            this.loggedInPanel.Controls.Add(this.Togglebtn);
            this.loggedInPanel.Location = new System.Drawing.Point(68, 59);
            this.loggedInPanel.Name = "loggedInPanel";
            this.loggedInPanel.Size = new System.Drawing.Size(430, 262);
            this.loggedInPanel.TabIndex = 11;
            this.loggedInPanel.Visible = false;
            // 
            // ShowFormat
            // 
            this.ShowFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowFormat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(59)))), ((int)(((byte)(212)))));
            this.ShowFormat.Location = new System.Drawing.Point(3, 212);
            this.ShowFormat.Name = "ShowFormat";
            this.ShowFormat.Size = new System.Drawing.Size(110, 47);
            this.ShowFormat.TabIndex = 10;
            this.ShowFormat.Text = "Show format";
            this.ShowFormat.UseVisualStyleBackColor = false;
            this.ShowFormat.Click += new System.EventHandler(this.ShowFormat_Click);
            // 
            // characterCounter
            // 
            this.characterCounter.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(59)))), ((int)(((byte)(212)))));
            this.characterCounter.Location = new System.Drawing.Point(371, 205);
            this.characterCounter.Name = "characterCounter";
            this.characterCounter.Size = new System.Drawing.Size(56, 20);
            this.characterCounter.TabIndex = 9;
            this.characterCounter.Text = "0/4000";
            this.characterCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // biotbx
            // 
            this.biotbx.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biotbx.Location = new System.Drawing.Point(3, 53);
            this.biotbx.MaxLength = 4000;
            this.biotbx.Multiline = true;
            this.biotbx.Name = "biotbx";
            this.biotbx.Size = new System.Drawing.Size(424, 149);
            this.biotbx.TabIndex = 8;
            this.biotbx.TextChanged += new System.EventHandler(this.Biotbx_TextChanged);
            // 
            // Biolbl
            // 
            this.Biolbl.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Biolbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(59)))), ((int)(((byte)(212)))));
            this.Biolbl.Location = new System.Drawing.Point(119, 13);
            this.Biolbl.Name = "Biolbl";
            this.Biolbl.Size = new System.Drawing.Size(192, 31);
            this.Biolbl.TabIndex = 7;
            this.Biolbl.Text = "Bio";
            this.Biolbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.NotifyIcon_Click);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 333);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.passwordtbx);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.usernametbx);
            this.Controls.Add(this.hidebtn);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.loggedInPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Updater";
            this.Text = "Updater";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Updater_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Updater_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.loggedInPanel.ResumeLayout(false);
            this.loggedInPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser Browser;
        private System.Windows.Forms.Button Togglebtn;
        private System.Windows.Forms.Timer BioUpdater;
        private System.Windows.Forms.PictureBox closebtn;
        private System.Windows.Forms.PictureBox hidebtn;
        private System.Windows.Forms.TextBox usernametbx;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.TextBox passwordtbx;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Timer loggedInTimer;
        private System.Windows.Forms.Panel loggedInPanel;
        private System.Windows.Forms.TextBox biotbx;
        private System.Windows.Forms.Label Biolbl;
        private System.Windows.Forms.Label characterCounter;
        private System.Windows.Forms.Button ShowFormat;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

