namespace RGB
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
            this.rdbFindGray = new System.Windows.Forms.RadioButton();
            this.rdbFindR = new System.Windows.Forms.RadioButton();
            this.rdbFindG = new System.Windows.Forms.RadioButton();
            this.rdbFindB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.numG = new System.Windows.Forms.NumericUpDown();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.numR = new System.Windows.Forms.NumericUpDown();
            this.numGray = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGray)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbFindGray
            // 
            this.rdbFindGray.AutoSize = true;
            this.rdbFindGray.Checked = true;
            this.rdbFindGray.Location = new System.Drawing.Point(12, 12);
            this.rdbFindGray.Name = "rdbFindGray";
            this.rdbFindGray.Size = new System.Drawing.Size(55, 17);
            this.rdbFindGray.TabIndex = 1;
            this.rdbFindGray.TabStop = true;
            this.rdbFindGray.Text = "Find Y";
            this.rdbFindGray.UseVisualStyleBackColor = true;
            // 
            // rdbFindR
            // 
            this.rdbFindR.AutoSize = true;
            this.rdbFindR.Location = new System.Drawing.Point(12, 35);
            this.rdbFindR.Name = "rdbFindR";
            this.rdbFindR.Size = new System.Drawing.Size(56, 17);
            this.rdbFindR.TabIndex = 2;
            this.rdbFindR.Text = "Find R";
            this.rdbFindR.UseVisualStyleBackColor = true;
            // 
            // rdbFindG
            // 
            this.rdbFindG.AutoSize = true;
            this.rdbFindG.Location = new System.Drawing.Point(12, 58);
            this.rdbFindG.Name = "rdbFindG";
            this.rdbFindG.Size = new System.Drawing.Size(56, 17);
            this.rdbFindG.TabIndex = 3;
            this.rdbFindG.Text = "Find G";
            this.rdbFindG.UseVisualStyleBackColor = true;
            // 
            // rdbFindB
            // 
            this.rdbFindB.AutoSize = true;
            this.rdbFindB.Location = new System.Drawing.Point(12, 81);
            this.rdbFindB.Name = "rdbFindB";
            this.rdbFindB.Size = new System.Drawing.Size(55, 17);
            this.rdbFindB.TabIndex = 4;
            this.rdbFindB.Text = "Find B";
            this.rdbFindB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gray";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 117);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(378, 35);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // numG
            // 
            this.numG.Location = new System.Drawing.Point(208, 9);
            this.numG.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numG.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numG.Name = "numG";
            this.numG.Size = new System.Drawing.Size(58, 20);
            this.numG.TabIndex = 14;
            // 
            // numB
            // 
            this.numB.Location = new System.Drawing.Point(292, 9);
            this.numB.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numB.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(58, 20);
            this.numB.TabIndex = 15;
            // 
            // numR
            // 
            this.numR.Location = new System.Drawing.Point(125, 9);
            this.numR.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numR.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numR.Name = "numR";
            this.numR.Size = new System.Drawing.Size(58, 20);
            this.numR.TabIndex = 13;
            // 
            // numGray
            // 
            this.numGray.Location = new System.Drawing.Point(195, 55);
            this.numGray.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numGray.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numGray.Name = "numGray";
            this.numGray.Size = new System.Drawing.Size(58, 20);
            this.numGray.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 164);
            this.Controls.Add(this.numGray);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.numG);
            this.Controls.Add(this.numR);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbFindB);
            this.Controls.Add(this.rdbFindG);
            this.Controls.Add(this.rdbFindR);
            this.Controls.Add(this.rdbFindGray);
            this.Name = "Form1";
            this.Text = "RGB calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbFindGray;
        private System.Windows.Forms.RadioButton rdbFindR;
        private System.Windows.Forms.RadioButton rdbFindG;
        private System.Windows.Forms.RadioButton rdbFindB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown numG;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.NumericUpDown numR;
        private System.Windows.Forms.NumericUpDown numGray;
    }
}

