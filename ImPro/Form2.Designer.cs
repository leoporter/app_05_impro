namespace ImPro
{
    partial class Form2
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
            this.cmbBox_MaskSize = new System.Windows.Forms.ComboBox();
            this.pctBox_ImageSpace = new System.Windows.Forms.PictureBox();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txtBox_SelectedFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_ImageSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mask size";
            // 
            // cmbBox_MaskSize
            // 
            this.cmbBox_MaskSize.Enabled = false;
            this.cmbBox_MaskSize.FormattingEnabled = true;
            this.cmbBox_MaskSize.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "9"});
            this.cmbBox_MaskSize.Location = new System.Drawing.Point(158, 22);
            this.cmbBox_MaskSize.Name = "cmbBox_MaskSize";
            this.cmbBox_MaskSize.Size = new System.Drawing.Size(51, 21);
            this.cmbBox_MaskSize.TabIndex = 1;
            // 
            // pctBox_ImageSpace
            // 
            this.pctBox_ImageSpace.Location = new System.Drawing.Point(12, 52);
            this.pctBox_ImageSpace.Name = "pctBox_ImageSpace";
            this.pctBox_ImageSpace.Size = new System.Drawing.Size(574, 432);
            this.pctBox_ImageSpace.TabIndex = 2;
            this.pctBox_ImageSpace.TabStop = false;
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(224, 22);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(75, 23);
            this.btn_Apply.TabIndex = 4;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.imApply);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(305, 22);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.imSave);
            // 
            // txtBox_SelectedFilter
            // 
            this.txtBox_SelectedFilter.Location = new System.Drawing.Point(15, 23);
            this.txtBox_SelectedFilter.Name = "txtBox_SelectedFilter";
            this.txtBox_SelectedFilter.ReadOnly = true;
            this.txtBox_SelectedFilter.Size = new System.Drawing.Size(137, 20);
            this.txtBox_SelectedFilter.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chosen filter:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 535);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_SelectedFilter);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.pctBox_ImageSpace);
            this.Controls.Add(this.cmbBox_MaskSize);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Filter Dialog";
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_ImageSpace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBox_MaskSize;
        private System.Windows.Forms.PictureBox pctBox_ImageSpace;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txtBox_SelectedFilter;
        private System.Windows.Forms.Label label2;
    }
}