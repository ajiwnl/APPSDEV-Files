namespace Fraction_Calculator
{
    partial class FractionCalculatorForm
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
            this.OptCmbBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Num1TxtBox = new System.Windows.Forms.TextBox();
            this.Denom1TxtBox = new System.Windows.Forms.TextBox();
            this.Num2TxtBox = new System.Windows.Forms.TextBox();
            this.Denom2TxtBox = new System.Windows.Forms.TextBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OptCmbBox
            // 
            this.OptCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OptCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptCmbBox.FormattingEnabled = true;
            this.OptCmbBox.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "÷"});
            this.OptCmbBox.Location = new System.Drawing.Point(139, 113);
            this.OptCmbBox.Name = "OptCmbBox";
            this.OptCmbBox.Size = new System.Drawing.Size(42, 28);
            this.OptCmbBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            // 
            // Num1TxtBox
            // 
            this.Num1TxtBox.Location = new System.Drawing.Point(81, 93);
            this.Num1TxtBox.Name = "Num1TxtBox";
            this.Num1TxtBox.Size = new System.Drawing.Size(35, 20);
            this.Num1TxtBox.TabIndex = 3;
            // 
            // Denom1TxtBox
            // 
            this.Denom1TxtBox.Location = new System.Drawing.Point(81, 132);
            this.Denom1TxtBox.Name = "Denom1TxtBox";
            this.Denom1TxtBox.Size = new System.Drawing.Size(35, 20);
            this.Denom1TxtBox.TabIndex = 4;
            // 
            // Num2TxtBox
            // 
            this.Num2TxtBox.Location = new System.Drawing.Point(207, 93);
            this.Num2TxtBox.Name = "Num2TxtBox";
            this.Num2TxtBox.Size = new System.Drawing.Size(35, 20);
            this.Num2TxtBox.TabIndex = 5;
            // 
            // Denom2TxtBox
            // 
            this.Denom2TxtBox.Location = new System.Drawing.Point(207, 132);
            this.Denom2TxtBox.Name = "Denom2TxtBox";
            this.Denom2TxtBox.Size = new System.Drawing.Size(35, 20);
            this.Denom2TxtBox.TabIndex = 6;
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(105, 202);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(112, 45);
            this.CalcBtn.TabIndex = 7;
            this.CalcBtn.Text = "Calculate";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Simple Fraction Calculator";
            // 
            // FractionCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 302);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.Denom2TxtBox);
            this.Controls.Add(this.Num2TxtBox);
            this.Controls.Add(this.Denom1TxtBox);
            this.Controls.Add(this.Num1TxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OptCmbBox);
            this.MaximizeBox = false;
            this.Name = "FractionCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fraction Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OptCmbBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Num1TxtBox;
        private System.Windows.Forms.TextBox Denom1TxtBox;
        private System.Windows.Forms.TextBox Num2TxtBox;
        private System.Windows.Forms.TextBox Denom2TxtBox;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Label label3;
    }
}

