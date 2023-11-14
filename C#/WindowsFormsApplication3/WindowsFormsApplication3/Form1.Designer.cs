namespace WindowsFormsApplication3
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
            this.lblip = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.tbip = new System.Windows.Forms.TextBox();
            this.tbnum = new System.Windows.Forms.TextBox();
            this.btnconect = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.tbsend = new System.Windows.Forms.TextBox();
            this.lblprop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblip
            // 
            this.lblip.AutoSize = true;
            this.lblip.Location = new System.Drawing.Point(26, 13);
            this.lblip.Name = "lblip";
            this.lblip.Size = new System.Drawing.Size(65, 13);
            this.lblip.TabIndex = 0;
            this.lblip.Text = "سرورIPآدرس";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(167, 13);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(62, 13);
            this.lblnum.TabIndex = 1;
            this.lblnum.Text = "شماره پورت";
            // 
            // tbip
            // 
            this.tbip.Location = new System.Drawing.Point(12, 43);
            this.tbip.Name = "tbip";
            this.tbip.Size = new System.Drawing.Size(100, 20);
            this.tbip.TabIndex = 2;
            // 
            // tbnum
            // 
            this.tbnum.Location = new System.Drawing.Point(154, 43);
            this.tbnum.Name = "tbnum";
            this.tbnum.Size = new System.Drawing.Size(100, 20);
            this.tbnum.TabIndex = 3;
            // 
            // btnconect
            // 
            this.btnconect.Location = new System.Drawing.Point(103, 82);
            this.btnconect.Name = "btnconect";
            this.btnconect.Size = new System.Drawing.Size(75, 23);
            this.btnconect.TabIndex = 4;
            this.btnconect.Text = "مجوز ارتباط";
            this.btnconect.UseVisualStyleBackColor = true;
            this.btnconect.Click += new System.EventHandler(this.btnconect_Click);
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(103, 143);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 23);
            this.btnsend.TabIndex = 5;
            this.btnsend.Text = "ارسال";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // tbsend
            // 
            this.tbsend.Location = new System.Drawing.Point(91, 172);
            this.tbsend.Name = "tbsend";
            this.tbsend.Size = new System.Drawing.Size(100, 20);
            this.tbsend.TabIndex = 6;
            // 
            // lblprop
            // 
            this.lblprop.AutoSize = true;
            this.lblprop.Location = new System.Drawing.Point(116, 112);
            this.lblprop.Name = "lblprop";
            this.lblprop.Size = new System.Drawing.Size(0, 13);
            this.lblprop.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblprop);
            this.Controls.Add(this.tbsend);
            this.Controls.Add(this.btnsend);
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

        private System.Windows.Forms.Label lblip;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.TextBox tbip;
        private System.Windows.Forms.TextBox tbnum;
        private System.Windows.Forms.Button btnconect;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.TextBox tbsend;
        private System.Windows.Forms.Label lblprop;
    }
}

