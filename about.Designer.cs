namespace bit_convert
{
    partial class about
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_back = new System.Windows.Forms.Button();
            this.richTextBox_version = new System.Windows.Forms.RichTextBox();
            this.linkLabel_mail = new System.Windows.Forms.LinkLabel();
            this.label_author = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(133, 242);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 28);
            this.button_back.TabIndex = 10;
            this.button_back.Text = "OK";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // richTextBox_version
            // 
            this.richTextBox_version.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_version.Location = new System.Drawing.Point(12, 75);
            this.richTextBox_version.Name = "richTextBox_version";
            this.richTextBox_version.Size = new System.Drawing.Size(351, 148);
            this.richTextBox_version.TabIndex = 9;
            this.richTextBox_version.Text = "This is a free software used for converting an integer between decimal, hexadecim" +
    "al, binary.\n\nVersion 1 (2019-11-12)\n- The basic function of integer converted";
            // 
            // linkLabel_mail
            // 
            this.linkLabel_mail.AutoSize = true;
            this.linkLabel_mail.Location = new System.Drawing.Point(143, 40);
            this.linkLabel_mail.Name = "linkLabel_mail";
            this.linkLabel_mail.Size = new System.Drawing.Size(93, 20);
            this.linkLabel_mail.TabIndex = 8;
            this.linkLabel_mail.TabStop = true;
            this.linkLabel_mail.Text = "Minpu Kang";
            this.linkLabel_mail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_mail_LinkClicked_1);
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Location = new System.Drawing.Point(76, 40);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(61, 20);
            this.label_author.TabIndex = 7;
            this.label_author.Text = "Author:";
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Location = new System.Drawing.Point(77, 10);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(87, 20);
            this.label_version.TabIndex = 6;
            this.label_version.Text = "Bit Convert";
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(403, 282);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.richTextBox_version);
            this.Controls.Add(this.linkLabel_mail);
            this.Controls.Add(this.label_author);
            this.Controls.Add(this.label_version);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "about";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.RichTextBox richTextBox_version;
        private System.Windows.Forms.LinkLabel linkLabel_mail;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_version;
    }
}