namespace Rectangle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LengthIn = new System.Windows.Forms.TextBox();
            this.WidthIn = new System.Windows.Forms.TextBox();
            this.HeightIn = new System.Windows.Forms.TextBox();
            this.DisplayBtn = new System.Windows.Forms.Button();
            this.RectangleRadBtn = new System.Windows.Forms.RadioButton();
            this.BoxRadBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height";
            // 
            // LengthIn
            // 
            this.LengthIn.Location = new System.Drawing.Point(290, 57);
            this.LengthIn.Margin = new System.Windows.Forms.Padding(5);
            this.LengthIn.Name = "LengthIn";
            this.LengthIn.Size = new System.Drawing.Size(164, 26);
            this.LengthIn.TabIndex = 3;
            // 
            // WidthIn
            // 
            this.WidthIn.Location = new System.Drawing.Point(290, 93);
            this.WidthIn.Margin = new System.Windows.Forms.Padding(5);
            this.WidthIn.Name = "WidthIn";
            this.WidthIn.Size = new System.Drawing.Size(164, 26);
            this.WidthIn.TabIndex = 4;
            // 
            // HeightIn
            // 
            this.HeightIn.Location = new System.Drawing.Point(290, 129);
            this.HeightIn.Margin = new System.Windows.Forms.Padding(5);
            this.HeightIn.Name = "HeightIn";
            this.HeightIn.Size = new System.Drawing.Size(164, 26);
            this.HeightIn.TabIndex = 5;
            // 
            // DisplayBtn
            // 
            this.DisplayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayBtn.Location = new System.Drawing.Point(264, 249);
            this.DisplayBtn.Margin = new System.Windows.Forms.Padding(5);
            this.DisplayBtn.Name = "DisplayBtn";
            this.DisplayBtn.Size = new System.Drawing.Size(137, 42);
            this.DisplayBtn.TabIndex = 6;
            this.DisplayBtn.Text = "Display";
            this.DisplayBtn.UseVisualStyleBackColor = true;
            this.DisplayBtn.Click += new System.EventHandler(this.DisplayBtn_Click);
            // 
            // RectangleRadBtn
            // 
            this.RectangleRadBtn.AutoSize = true;
            this.RectangleRadBtn.Location = new System.Drawing.Point(264, 178);
            this.RectangleRadBtn.Name = "RectangleRadBtn";
            this.RectangleRadBtn.Size = new System.Drawing.Size(189, 24);
            this.RectangleRadBtn.TabIndex = 7;
            this.RectangleRadBtn.TabStop = true;
            this.RectangleRadBtn.Text = "Calculate Rectangle";
            this.RectangleRadBtn.UseVisualStyleBackColor = true;
            // 
            // BoxRadBtn
            // 
            this.BoxRadBtn.AutoSize = true;
            this.BoxRadBtn.Location = new System.Drawing.Point(264, 217);
            this.BoxRadBtn.Name = "BoxRadBtn";
            this.BoxRadBtn.Size = new System.Drawing.Size(137, 24);
            this.BoxRadBtn.TabIndex = 8;
            this.BoxRadBtn.TabStop = true;
            this.BoxRadBtn.Text = "Calculate Box";
            this.BoxRadBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 382);
            this.Controls.Add(this.BoxRadBtn);
            this.Controls.Add(this.RectangleRadBtn);
            this.Controls.Add(this.DisplayBtn);
            this.Controls.Add(this.HeightIn);
            this.Controls.Add(this.WidthIn);
            this.Controls.Add(this.LengthIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LengthIn;
        private System.Windows.Forms.TextBox WidthIn;
        private System.Windows.Forms.TextBox HeightIn;
        private System.Windows.Forms.Button DisplayBtn;
        private System.Windows.Forms.RadioButton RectangleRadBtn;
        private System.Windows.Forms.RadioButton BoxRadBtn;
    }
}

