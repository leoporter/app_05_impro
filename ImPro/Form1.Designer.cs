﻿namespace ImPro
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.trBar_Brightness = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_Brightness = new System.Windows.Forms.TextBox();
            this.btn_Invert = new System.Windows.Forms.Button();
            this.btn_CompareRGB = new System.Windows.Forms.Button();
            this.btn_Rotate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBar_Brightness)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 8);
            this.button1.MinimumSize = new System.Drawing.Size(120, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.imLoad);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(104, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 341);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(71, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height:";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(597, 8);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 445);
            this.vScrollBar1.TabIndex = 6;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Greyscale";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_Gray_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.imSave);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(151, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Count unique pixels";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_CountPixels_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(151, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(107, 20);
            this.textBox3.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(283, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Filter Options";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.imLowPassFilter);
            // 
            // trBar_Brightness
            // 
            this.trBar_Brightness.Location = new System.Drawing.Point(407, 24);
            this.trBar_Brightness.Maximum = 50;
            this.trBar_Brightness.Name = "trBar_Brightness";
            this.trBar_Brightness.Size = new System.Drawing.Size(164, 45);
            this.trBar_Brightness.TabIndex = 12;
            this.trBar_Brightness.ValueChanged += new System.EventHandler(this.SetBrightness);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Brightness";
            // 
            // txtBox_Brightness
            // 
            this.txtBox_Brightness.Location = new System.Drawing.Point(466, 5);
            this.txtBox_Brightness.Name = "txtBox_Brightness";
            this.txtBox_Brightness.ReadOnly = true;
            this.txtBox_Brightness.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Brightness.TabIndex = 14;
            // 
            // btn_Invert
            // 
            this.btn_Invert.Location = new System.Drawing.Point(283, 73);
            this.btn_Invert.Name = "btn_Invert";
            this.btn_Invert.Size = new System.Drawing.Size(88, 23);
            this.btn_Invert.TabIndex = 15;
            this.btn_Invert.Text = "Invert";
            this.btn_Invert.UseVisualStyleBackColor = true;
            this.btn_Invert.Click += new System.EventHandler(this.btn_Click_Invert);
            // 
            // btn_CompareRGB
            // 
            this.btn_CompareRGB.Location = new System.Drawing.Point(407, 60);
            this.btn_CompareRGB.Name = "btn_CompareRGB";
            this.btn_CompareRGB.Size = new System.Drawing.Size(127, 23);
            this.btn_CompareRGB.TabIndex = 16;
            this.btn_CompareRGB.Text = "Compare RGB Weights";
            this.btn_CompareRGB.UseVisualStyleBackColor = true;
            this.btn_CompareRGB.Click += new System.EventHandler(this.btn_Click_CompareRGBWeights);
            // 
            // btn_Rotate
            // 
            this.btn_Rotate.Location = new System.Drawing.Point(12, 114);
            this.btn_Rotate.Name = "btn_Rotate";
            this.btn_Rotate.Size = new System.Drawing.Size(75, 23);
            this.btn_Rotate.TabIndex = 17;
            this.btn_Rotate.Text = "Rotate";
            this.btn_Rotate.UseVisualStyleBackColor = true;
            this.btn_Rotate.Click += new System.EventHandler(this.btn_Click_Rotate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 465);
            this.Controls.Add(this.btn_Rotate);
            this.Controls.Add(this.btn_CompareRGB);
            this.Controls.Add(this.btn_Invert);
            this.Controls.Add(this.txtBox_Brightness);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trBar_Brightness);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "ImPro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBar_Brightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TrackBar trBar_Brightness;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_Brightness;
        private System.Windows.Forms.Button btn_Invert;
        private System.Windows.Forms.Button btn_CompareRGB;
        private System.Windows.Forms.Button btn_Rotate;
    }
}

