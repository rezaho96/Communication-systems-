namespace WindowsFormsApplication4
{
    partial class Form1
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
            this.lblprop = new System.Windows.Forms.Label();
            this.tbrecieve = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnconect = new System.Windows.Forms.Button();
            this.tbnum = new System.Windows.Forms.TextBox();
            this.tbip = new System.Windows.Forms.TextBox();
            this.lblnum = new System.Windows.Forms.Label();
            this.lblip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblprop
            // 
            this.lblprop.AutoSize = true;
            this.lblprop.Location = new System.Drawing.Point(125, 140);
            this.lblprop.Name = "lblprop";
            this.lblprop.Size = new System.Drawing.Size(0, 13);
            this.lblprop.TabIndex = 15;
            // 
            // tbrecieve
            // 
            this.tbrecieve.Location = new System.Drawing.Point(87, 155);
            this.tbrecieve.Name = "tbrecieve";
            this.tbrecieve.Size = new System.Drawing.Size(100, 20);
            this.tbrecieve.TabIndex = 14;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(100, 181);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(87, 23);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "به روز رسانی";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnconect
            // 
            this.btnconect.Location = new System.Drawing.Point(112, 110);
            this.btnconect.Name = "btnconect";
            this.btnconect.Size = new System.Drawing.Size(75, 23);
            this.btnconect.TabIndex = 12;
            this.btnconect.Text = "اتصال";
            this.btnconect.UseVisualStyleBackColor = true;
            this.btnconect.Click += new System.EventHandler(this.btnconect_Click);
            // 
            // tbnum
            // 
            this.tbnum.Location = new System.Drawing.Point(163, 71);
            this.tbnum.Name = "tbnum";
            this.tbnum.Size = new System.Drawing.Size(100, 20);
            this.tbnum.TabIndex = 11;
            // 
            // tbip
            // 
            this.tbip.Location = new System.Drawing.Point(21, 71);
            this.tbip.Name = "tbip";
            this.tbip.Size = new System.Drawing.Size(100, 20);
            this.tbip.TabIndex = 10;
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(176, 41);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(62, 13);
            this.lblnum.TabIndex = 9;
            this.lblnum.Text = "شماره پورت";
            // 
            // lblip
            // 
            this.lblip.AutoSize = true;
            this.lblip.Location = new System.Drawing.Point(35, 41);
            this.lblip.Name = "lblip";
            this.lblip.Size = new System.Drawing.Size(70, 13);
            this.lblip.TabIndex = 8;
            this.lblip.Text = "کلاینتIPآدرس";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblprop);
            this.Controls.Add(this.tbrecieve);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnconect);
            this.Controls.Add(this.tbnum);
            this.Controls.Add(this.tbip);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.lblip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprop;
        private System.Windows.Forms.TextBox tbrecieve;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnconect;
        private System.Windows.Forms.TextBox tbnum;
        private System.Windows.Forms.TextBox tbip;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lblip;
    }
}

