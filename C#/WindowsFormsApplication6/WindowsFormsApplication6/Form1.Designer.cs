namespace WindowsFormsApplication6
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
            this.components = new System.ComponentModel.Container();
            this.lblprop = new System.Windows.Forms.Label();
            this.btnconect = new System.Windows.Forms.Button();
            this.tbnum = new System.Windows.Forms.TextBox();
            this.tbip = new System.Windows.Forms.TextBox();
            this.lblnum = new System.Windows.Forms.Label();
            this.lblip = new System.Windows.Forms.Label();
            this.trecieve = new System.Windows.Forms.Timer(this.components);
            this.lblrecieve = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblprop
            // 
            this.lblprop.AutoSize = true;
            this.lblprop.Location = new System.Drawing.Point(125, 162);
            this.lblprop.Name = "lblprop";
            this.lblprop.Size = new System.Drawing.Size(0, 13);
            this.lblprop.TabIndex = 22;
            // 
            // btnconect
            // 
            this.btnconect.Location = new System.Drawing.Point(112, 132);
            this.btnconect.Name = "btnconect";
            this.btnconect.Size = new System.Drawing.Size(75, 23);
            this.btnconect.TabIndex = 20;
            this.btnconect.Text = "اتصال";
            this.btnconect.UseVisualStyleBackColor = true;
            this.btnconect.Click += new System.EventHandler(this.btnconect_Click);
            // 
            // tbnum
            // 
            this.tbnum.Location = new System.Drawing.Point(163, 93);
            this.tbnum.Name = "tbnum";
            this.tbnum.Size = new System.Drawing.Size(100, 20);
            this.tbnum.TabIndex = 19;
            // 
            // tbip
            // 
            this.tbip.Location = new System.Drawing.Point(21, 93);
            this.tbip.Name = "tbip";
            this.tbip.Size = new System.Drawing.Size(100, 20);
            this.tbip.TabIndex = 18;
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(176, 63);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(62, 13);
            this.lblnum.TabIndex = 17;
            this.lblnum.Text = "شماره پورت";
            // 
            // lblip
            // 
            this.lblip.AutoSize = true;
            this.lblip.Location = new System.Drawing.Point(35, 63);
            this.lblip.Name = "lblip";
            this.lblip.Size = new System.Drawing.Size(70, 13);
            this.lblip.TabIndex = 16;
            this.lblip.Text = "کلاینتIPآدرس";
            // 
            // trecieve
            // 
            this.trecieve.Interval = 3000;
            this.trecieve.Tick += new System.EventHandler(this.trecieve_Tick);
            // 
            // lblrecieve
            // 
            this.lblrecieve.AutoSize = true;
            this.lblrecieve.Location = new System.Drawing.Point(109, 194);
            this.lblrecieve.Name = "lblrecieve";
            this.lblrecieve.Size = new System.Drawing.Size(0, 13);
            this.lblrecieve.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblrecieve);
            this.Controls.Add(this.lblprop);
            this.Controls.Add(this.btnconect);
            this.Controls.Add(this.tbnum);
            this.Controls.Add(this.tbip);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.lblip);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprop;
        private System.Windows.Forms.Button btnconect;
        private System.Windows.Forms.TextBox tbnum;
        private System.Windows.Forms.TextBox tbip;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lblip;
        private System.Windows.Forms.Timer trecieve;
        private System.Windows.Forms.Label lblrecieve;
    }
}

