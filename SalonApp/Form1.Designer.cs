namespace SalonApp
{
    partial class SalonAppForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TenPercentRadBtn = new System.Windows.Forms.RadioButton();
            this.TwentyPercentRadBtn = new System.Windows.Forms.RadioButton();
            this.NoneRadBtn = new System.Windows.Forms.RadioButton();
            this.MakeOverChkBox = new System.Windows.Forms.CheckBox();
            this.MakeUpChkBox = new System.Windows.Forms.CheckBox();
            this.MaskaraChkBox = new System.Windows.Forms.CheckBox();
            this.HaircutChkBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrentChargeLbl = new System.Windows.Forms.Label();
            this.DiscountLbl = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "\"Salon Title Here\"";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HaircutChkBox);
            this.groupBox1.Controls.Add(this.MaskaraChkBox);
            this.groupBox1.Controls.Add(this.MakeUpChkBox);
            this.groupBox1.Controls.Add(this.MakeOverChkBox);
            this.groupBox1.Location = new System.Drawing.Point(90, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services Offered";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TotalLbl);
            this.groupBox2.Controls.Add(this.DiscountLbl);
            this.groupBox2.Controls.Add(this.CurrentChargeLbl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(375, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 258);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summary";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(288, 344);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(93, 38);
            this.CalculateBtn.TabIndex = 3;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NoneRadBtn);
            this.groupBox3.Controls.Add(this.TwentyPercentRadBtn);
            this.groupBox3.Controls.Add(this.TenPercentRadBtn);
            this.groupBox3.Location = new System.Drawing.Point(90, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 121);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Discount";
            // 
            // TenPercentRadBtn
            // 
            this.TenPercentRadBtn.AutoSize = true;
            this.TenPercentRadBtn.Location = new System.Drawing.Point(39, 30);
            this.TenPercentRadBtn.Name = "TenPercentRadBtn";
            this.TenPercentRadBtn.Size = new System.Drawing.Size(45, 17);
            this.TenPercentRadBtn.TabIndex = 0;
            this.TenPercentRadBtn.TabStop = true;
            this.TenPercentRadBtn.Text = "10%";
            this.TenPercentRadBtn.UseVisualStyleBackColor = true;
            // 
            // TwentyPercentRadBtn
            // 
            this.TwentyPercentRadBtn.AutoSize = true;
            this.TwentyPercentRadBtn.Location = new System.Drawing.Point(39, 65);
            this.TwentyPercentRadBtn.Name = "TwentyPercentRadBtn";
            this.TwentyPercentRadBtn.Size = new System.Drawing.Size(45, 17);
            this.TwentyPercentRadBtn.TabIndex = 1;
            this.TwentyPercentRadBtn.TabStop = true;
            this.TwentyPercentRadBtn.Text = "20%";
            this.TwentyPercentRadBtn.UseVisualStyleBackColor = true;
            // 
            // NoneRadBtn
            // 
            this.NoneRadBtn.AutoSize = true;
            this.NoneRadBtn.Location = new System.Drawing.Point(39, 95);
            this.NoneRadBtn.Name = "NoneRadBtn";
            this.NoneRadBtn.Size = new System.Drawing.Size(39, 17);
            this.NoneRadBtn.TabIndex = 2;
            this.NoneRadBtn.TabStop = true;
            this.NoneRadBtn.Text = "0%";
            this.NoneRadBtn.UseVisualStyleBackColor = true;
            // 
            // MakeOverChkBox
            // 
            this.MakeOverChkBox.AutoSize = true;
            this.MakeOverChkBox.Location = new System.Drawing.Point(39, 19);
            this.MakeOverChkBox.Name = "MakeOverChkBox";
            this.MakeOverChkBox.Size = new System.Drawing.Size(104, 17);
            this.MakeOverChkBox.TabIndex = 0;
            this.MakeOverChkBox.Text = "Salon Makeover";
            this.MakeOverChkBox.UseVisualStyleBackColor = true;
            // 
            // MakeUpChkBox
            // 
            this.MakeUpChkBox.AutoSize = true;
            this.MakeUpChkBox.Location = new System.Drawing.Point(39, 42);
            this.MakeUpChkBox.Name = "MakeUpChkBox";
            this.MakeUpChkBox.Size = new System.Drawing.Size(122, 17);
            this.MakeUpChkBox.TabIndex = 1;
            this.MakeUpChkBox.Text = "Permanent Make-up";
            this.MakeUpChkBox.UseVisualStyleBackColor = true;
            // 
            // MaskaraChkBox
            // 
            this.MaskaraChkBox.AutoSize = true;
            this.MaskaraChkBox.Location = new System.Drawing.Point(39, 65);
            this.MaskaraChkBox.Name = "MaskaraChkBox";
            this.MaskaraChkBox.Size = new System.Drawing.Size(67, 17);
            this.MaskaraChkBox.TabIndex = 2;
            this.MaskaraChkBox.Text = "Maskara";
            this.MaskaraChkBox.UseVisualStyleBackColor = true;
            // 
            // HaircutChkBox
            // 
            this.HaircutChkBox.AutoSize = true;
            this.HaircutChkBox.Location = new System.Drawing.Point(39, 88);
            this.HaircutChkBox.Name = "HaircutChkBox";
            this.HaircutChkBox.Size = new System.Drawing.Size(94, 17);
            this.HaircutChkBox.TabIndex = 3;
            this.HaircutChkBox.Text = "Simple Haircut";
            this.HaircutChkBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current Charge";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Discount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total due";
            // 
            // CurrentChargeLbl
            // 
            this.CurrentChargeLbl.AutoSize = true;
            this.CurrentChargeLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CurrentChargeLbl.Location = new System.Drawing.Point(103, 23);
            this.CurrentChargeLbl.Name = "CurrentChargeLbl";
            this.CurrentChargeLbl.Size = new System.Drawing.Size(2, 15);
            this.CurrentChargeLbl.TabIndex = 3;
            // 
            // DiscountLbl
            // 
            this.DiscountLbl.AutoSize = true;
            this.DiscountLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DiscountLbl.Location = new System.Drawing.Point(103, 46);
            this.DiscountLbl.Name = "DiscountLbl";
            this.DiscountLbl.Size = new System.Drawing.Size(2, 15);
            this.DiscountLbl.TabIndex = 4;
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalLbl.Location = new System.Drawing.Point(103, 69);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(2, 15);
            this.TotalLbl.TabIndex = 5;
            // 
            // SalonAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 394);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "SalonAppForm";
            this.Text = "Salon App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox MakeOverChkBox;
        private System.Windows.Forms.RadioButton NoneRadBtn;
        private System.Windows.Forms.RadioButton TwentyPercentRadBtn;
        private System.Windows.Forms.RadioButton TenPercentRadBtn;
        private System.Windows.Forms.CheckBox HaircutChkBox;
        private System.Windows.Forms.CheckBox MaskaraChkBox;
        private System.Windows.Forms.CheckBox MakeUpChkBox;
        private System.Windows.Forms.Label CurrentChargeLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Label DiscountLbl;
    }
}

