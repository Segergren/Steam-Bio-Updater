namespace SteamCoronaUpdater
{
    partial class Format
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Format));
            this.closebtn = new System.Windows.Forms.PictureBox();
            this.formatbx = new System.Windows.Forms.TextBox();
            this.formatlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            this.SuspendLayout();
            // 
            // closebtn
            // 
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.Image = ((System.Drawing.Image)(resources.GetObject("closebtn.Image")));
            this.closebtn.Location = new System.Drawing.Point(422, 4);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(32, 32);
            this.closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closebtn.TabIndex = 5;
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // formatbx
            // 
            this.formatbx.BackColor = System.Drawing.Color.White;
            this.formatbx.Cursor = System.Windows.Forms.Cursors.Default;
            this.formatbx.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatbx.Location = new System.Drawing.Point(4, 47);
            this.formatbx.Multiline = true;
            this.formatbx.Name = "formatbx";
            this.formatbx.ReadOnly = true;
            this.formatbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.formatbx.Size = new System.Drawing.Size(450, 247);
            this.formatbx.TabIndex = 6;
            this.formatbx.Text = resources.GetString("formatbx.Text");
            this.formatbx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Formatbx_MouseDown);
            // 
            // formatlbl
            // 
            this.formatlbl.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(59)))), ((int)(((byte)(212)))));
            this.formatlbl.Location = new System.Drawing.Point(133, 4);
            this.formatlbl.Name = "formatlbl";
            this.formatlbl.Size = new System.Drawing.Size(192, 39);
            this.formatlbl.TabIndex = 7;
            this.formatlbl.Text = "Format";
            this.formatlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.formatlbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Formatlbl_MouseDown);
            // 
            // Format
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 298);
            this.Controls.Add(this.formatlbl);
            this.Controls.Add(this.formatbx);
            this.Controls.Add(this.closebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Format";
            this.Text = "Format";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Format_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Format_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox closebtn;
        private System.Windows.Forms.TextBox formatbx;
        private System.Windows.Forms.Label formatlbl;
    }
}