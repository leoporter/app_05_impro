namespace ImPro
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.rd_btn_LowPass = new System.Windows.Forms.RadioButton();
            this.rd_btn_HighPass = new System.Windows.Forms.RadioButton();
            this.rd_btn_Median = new System.Windows.Forms.RadioButton();
            this.rd_btn_Average = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose filter type";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(23, 168);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.DisplayFilterForm);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(137, 168);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.CancelAndLeave);
            // 
            // rd_btn_LowPass
            // 
            this.rd_btn_LowPass.AutoSize = true;
            this.rd_btn_LowPass.Location = new System.Drawing.Point(16, 26);
            this.rd_btn_LowPass.Name = "rd_btn_LowPass";
            this.rd_btn_LowPass.Size = new System.Drawing.Size(71, 17);
            this.rd_btn_LowPass.TabIndex = 5;
            this.rd_btn_LowPass.TabStop = true;
            this.rd_btn_LowPass.Text = "Low-Pass";
            this.rd_btn_LowPass.UseVisualStyleBackColor = true;
            // 
            // rd_btn_HighPass
            // 
            this.rd_btn_HighPass.AutoSize = true;
            this.rd_btn_HighPass.Location = new System.Drawing.Point(16, 49);
            this.rd_btn_HighPass.Name = "rd_btn_HighPass";
            this.rd_btn_HighPass.Size = new System.Drawing.Size(73, 17);
            this.rd_btn_HighPass.TabIndex = 6;
            this.rd_btn_HighPass.TabStop = true;
            this.rd_btn_HighPass.Text = "High-Pass";
            this.rd_btn_HighPass.UseVisualStyleBackColor = true;
            // 
            // rd_btn_Median
            // 
            this.rd_btn_Median.AutoSize = true;
            this.rd_btn_Median.Location = new System.Drawing.Point(16, 72);
            this.rd_btn_Median.Name = "rd_btn_Median";
            this.rd_btn_Median.Size = new System.Drawing.Size(60, 17);
            this.rd_btn_Median.TabIndex = 7;
            this.rd_btn_Median.TabStop = true;
            this.rd_btn_Median.Text = "Median";
            this.rd_btn_Median.UseVisualStyleBackColor = true;
            // 
            // rd_btn_Average
            // 
            this.rd_btn_Average.AutoSize = true;
            this.rd_btn_Average.Location = new System.Drawing.Point(16, 95);
            this.rd_btn_Average.Name = "rd_btn_Average";
            this.rd_btn_Average.Size = new System.Drawing.Size(65, 17);
            this.rd_btn_Average.TabIndex = 8;
            this.rd_btn_Average.TabStop = true;
            this.rd_btn_Average.Text = "Average";
            this.rd_btn_Average.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_btn_HighPass);
            this.groupBox1.Controls.Add(this.rd_btn_Average);
            this.groupBox1.Controls.Add(this.rd_btn_LowPass);
            this.groupBox1.Controls.Add(this.rd_btn_Median);
            this.groupBox1.Location = new System.Drawing.Point(74, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 120);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 208);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Filter choice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.RadioButton rd_btn_LowPass;
        private System.Windows.Forms.RadioButton rd_btn_HighPass;
        private System.Windows.Forms.RadioButton rd_btn_Median;
        private System.Windows.Forms.RadioButton rd_btn_Average;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}