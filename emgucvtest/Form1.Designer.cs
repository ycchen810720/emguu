namespace emgucvtest
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
            this.OpenImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TbOrdRow = new System.Windows.Forms.TextBox();
            this.TbOrdCol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbGrayLevel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbBlue = new System.Windows.Forms.TextBox();
            this.TbRed = new System.Windows.Forms.TextBox();
            this.TbGreen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenImage
            // 
            this.OpenImage.Location = new System.Drawing.Point(16, 35);
            this.OpenImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(100, 29);
            this.OpenImage.TabIndex = 0;
            this.OpenImage.Text = "BtnOpenImage";
            this.OpenImage.UseVisualStyleBackColor = true;
            this.OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(155, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 711);
            this.panel1.TabIndex = 2;
            // 
            // TbOrdRow
            // 
            this.TbOrdRow.Location = new System.Drawing.Point(16, 115);
            this.TbOrdRow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbOrdRow.Name = "TbOrdRow";
            this.TbOrdRow.Size = new System.Drawing.Size(48, 25);
            this.TbOrdRow.TabIndex = 3;
            // 
            // TbOrdCol
            // 
            this.TbOrdCol.Location = new System.Drawing.Point(95, 115);
            this.TbOrdCol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbOrdCol.Name = "TbOrdCol";
            this.TbOrdCol.Size = new System.Drawing.Size(51, 25);
            this.TbOrdCol.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "row";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "col";
            // 
            // TbGrayLevel
            // 
            this.TbGrayLevel.Location = new System.Drawing.Point(24, 168);
            this.TbGrayLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbGrayLevel.Name = "TbGrayLevel";
            this.TbGrayLevel.Size = new System.Drawing.Size(99, 25);
            this.TbGrayLevel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "graylevel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "r";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "g";
            // 
            // TbBlue
            // 
            this.TbBlue.Location = new System.Drawing.Point(12, 225);
            this.TbBlue.Name = "TbBlue";
            this.TbBlue.Size = new System.Drawing.Size(35, 25);
            this.TbBlue.TabIndex = 11;
            // 
            // TbRed
            // 
            this.TbRed.Location = new System.Drawing.Point(95, 225);
            this.TbRed.Name = "TbRed";
            this.TbRed.Size = new System.Drawing.Size(35, 25);
            this.TbRed.TabIndex = 12;
            // 
            // TbGreen
            // 
            this.TbGreen.Location = new System.Drawing.Point(53, 225);
            this.TbGreen.Name = "TbGreen";
            this.TbGreen.Size = new System.Drawing.Size(35, 25);
            this.TbGreen.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 761);
            this.Controls.Add(this.TbGreen);
            this.Controls.Add(this.TbRed);
            this.Controls.Add(this.TbBlue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbGrayLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbOrdCol);
            this.Controls.Add(this.TbOrdRow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OpenImage);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TbOrdRow;
        private System.Windows.Forms.TextBox TbOrdCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbGrayLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbBlue;
        private System.Windows.Forms.TextBox TbRed;
        private System.Windows.Forms.TextBox TbGreen;
    }
}

