namespace bit_convert
{
    partial class bc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bc));
            this.bin_textBox1 = new System.Windows.Forms.TextBox();
            this.alarm_label = new System.Windows.Forms.Label();
            this.bin_textBox = new System.Windows.Forms.TextBox();
            this.hex_textBox = new System.Windows.Forms.TextBox();
            this.dec_textBox = new System.Windows.Forms.TextBox();
            this.bin_label = new System.Windows.Forms.Label();
            this.hex_label = new System.Windows.Forms.Label();
            this.dec_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bin_textBox1
            // 
            this.bin_textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.bin_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bin_textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bin_textBox1.Location = new System.Drawing.Point(53, 92);
            this.bin_textBox1.Name = "bin_textBox1";
            this.bin_textBox1.ReadOnly = true;
            this.bin_textBox1.Size = new System.Drawing.Size(351, 26);
            this.bin_textBox1.TabIndex = 15;
            // 
            // alarm_label
            // 
            this.alarm_label.AutoSize = true;
            this.alarm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alarm_label.ForeColor = System.Drawing.Color.Red;
            this.alarm_label.Location = new System.Drawing.Point(41, 121);
            this.alarm_label.Name = "alarm_label";
            this.alarm_label.Size = new System.Drawing.Size(0, 20);
            this.alarm_label.TabIndex = 14;
            // 
            // bin_textBox
            // 
            this.bin_textBox.Location = new System.Drawing.Point(53, 65);
            this.bin_textBox.Name = "bin_textBox";
            this.bin_textBox.Size = new System.Drawing.Size(351, 26);
            this.bin_textBox.TabIndex = 13;
            this.bin_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bin_textBox_KeyUp);
            // 
            // hex_textBox
            // 
            this.hex_textBox.Location = new System.Drawing.Point(53, 35);
            this.hex_textBox.Name = "hex_textBox";
            this.hex_textBox.Size = new System.Drawing.Size(317, 26);
            this.hex_textBox.TabIndex = 12;
            this.hex_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.hex_textBox_KeyUp);
            // 
            // dec_textBox
            // 
            this.dec_textBox.Location = new System.Drawing.Point(53, 5);
            this.dec_textBox.Name = "dec_textBox";
            this.dec_textBox.Size = new System.Drawing.Size(276, 26);
            this.dec_textBox.TabIndex = 11;
            this.dec_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dec_textBox_KeyUp);
            // 
            // bin_label
            // 
            this.bin_label.AutoSize = true;
            this.bin_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bin_label.Location = new System.Drawing.Point(4, 70);
            this.bin_label.Name = "bin_label";
            this.bin_label.Size = new System.Drawing.Size(39, 20);
            this.bin_label.TabIndex = 10;
            this.bin_label.Text = "Bin:";
            // 
            // hex_label
            // 
            this.hex_label.AutoSize = true;
            this.hex_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hex_label.Location = new System.Drawing.Point(4, 39);
            this.hex_label.Name = "hex_label";
            this.hex_label.Size = new System.Drawing.Size(44, 20);
            this.hex_label.TabIndex = 9;
            this.hex_label.Text = "Hex:";
            // 
            // dec_label
            // 
            this.dec_label.AutoSize = true;
            this.dec_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dec_label.Location = new System.Drawing.Point(4, 8);
            this.dec_label.Name = "dec_label";
            this.dec_label.Size = new System.Drawing.Size(45, 20);
            this.dec_label.TabIndex = 8;
            this.dec_label.Text = "Dec:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abortToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(332, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(84, 156);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abortToolStripMenuItem
            // 
            this.abortToolStripMenuItem.Name = "abortToolStripMenuItem";
            this.abortToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.abortToolStripMenuItem.Text = "About";
            this.abortToolStripMenuItem.Click += new System.EventHandler(this.abortToolStripMenuItem_Click);
            // 
            // bc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(416, 156);
            this.Controls.Add(this.bin_textBox1);
            this.Controls.Add(this.alarm_label);
            this.Controls.Add(this.bin_textBox);
            this.Controls.Add(this.hex_textBox);
            this.Controls.Add(this.dec_textBox);
            this.Controls.Add(this.bin_label);
            this.Controls.Add(this.hex_label);
            this.Controls.Add(this.dec_label);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "bc";
            this.Text = "Bit Convert";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bin_textBox1;
        private System.Windows.Forms.Label alarm_label;
        private System.Windows.Forms.TextBox bin_textBox;
        private System.Windows.Forms.TextBox hex_textBox;
        private System.Windows.Forms.TextBox dec_textBox;
        private System.Windows.Forms.Label bin_label;
        private System.Windows.Forms.Label hex_label;
        private System.Windows.Forms.Label dec_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abortToolStripMenuItem;
    }
}

