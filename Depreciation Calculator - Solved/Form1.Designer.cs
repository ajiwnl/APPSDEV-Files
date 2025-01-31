namespace Financial_Calculator
{
    partial class DepreciationCalculator
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
            this.InitialCostTxtBox = new System.Windows.Forms.TextBox();
            this.SalvageValueTxtBox = new System.Windows.Forms.TextBox();
            this.LifeTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DDBRadBtn = new System.Windows.Forms.RadioButton();
            this.DBRadBtn = new System.Windows.Forms.RadioButton();
            this.SYDRadBtn = new System.Windows.Forms.RadioButton();
            this.SLNRadBtn = new System.Windows.Forms.RadioButton();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.OutputListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salvage Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Life";
            // 
            // InitialCostTxtBox
            // 
            this.InitialCostTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialCostTxtBox.Location = new System.Drawing.Point(129, 16);
            this.InitialCostTxtBox.Name = "InitialCostTxtBox";
            this.InitialCostTxtBox.Size = new System.Drawing.Size(165, 26);
            this.InitialCostTxtBox.TabIndex = 3;
            // 
            // SalvageValueTxtBox
            // 
            this.SalvageValueTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalvageValueTxtBox.Location = new System.Drawing.Point(129, 61);
            this.SalvageValueTxtBox.Name = "SalvageValueTxtBox";
            this.SalvageValueTxtBox.Size = new System.Drawing.Size(165, 26);
            this.SalvageValueTxtBox.TabIndex = 4;
            // 
            // LifeTxtBox
            // 
            this.LifeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LifeTxtBox.Location = new System.Drawing.Point(129, 106);
            this.LifeTxtBox.Name = "LifeTxtBox";
            this.LifeTxtBox.Size = new System.Drawing.Size(165, 26);
            this.LifeTxtBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DDBRadBtn);
            this.groupBox1.Controls.Add(this.DBRadBtn);
            this.groupBox1.Controls.Add(this.SYDRadBtn);
            this.groupBox1.Controls.Add(this.SLNRadBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(375, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 187);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depreciation";
            // 
            // DDBRadBtn
            // 
            this.DDBRadBtn.AutoSize = true;
            this.DDBRadBtn.Location = new System.Drawing.Point(6, 156);
            this.DDBRadBtn.Name = "DDBRadBtn";
            this.DDBRadBtn.Size = new System.Drawing.Size(209, 24);
            this.DDBRadBtn.TabIndex = 3;
            this.DDBRadBtn.TabStop = true;
            this.DDBRadBtn.Text = "Double Declining Balance";
            this.DDBRadBtn.UseVisualStyleBackColor = true;
            // 
            // DBRadBtn
            // 
            this.DBRadBtn.AutoSize = true;
            this.DBRadBtn.Location = new System.Drawing.Point(6, 116);
            this.DBRadBtn.Name = "DBRadBtn";
            this.DBRadBtn.Size = new System.Drawing.Size(154, 24);
            this.DBRadBtn.TabIndex = 2;
            this.DBRadBtn.TabStop = true;
            this.DBRadBtn.Text = "Declining Balance";
            this.DBRadBtn.UseVisualStyleBackColor = true;
            // 
            // SYDRadBtn
            // 
            this.SYDRadBtn.AutoSize = true;
            this.SYDRadBtn.Location = new System.Drawing.Point(6, 76);
            this.SYDRadBtn.Name = "SYDRadBtn";
            this.SYDRadBtn.Size = new System.Drawing.Size(124, 24);
            this.SYDRadBtn.TabIndex = 1;
            this.SYDRadBtn.TabStop = true;
            this.SYDRadBtn.Text = "Sum of Years";
            this.SYDRadBtn.UseVisualStyleBackColor = true;
            // 
            // SLNRadBtn
            // 
            this.SLNRadBtn.AutoSize = true;
            this.SLNRadBtn.Location = new System.Drawing.Point(6, 36);
            this.SLNRadBtn.Name = "SLNRadBtn";
            this.SLNRadBtn.Size = new System.Drawing.Size(117, 24);
            this.SLNRadBtn.TabIndex = 0;
            this.SLNRadBtn.TabStop = true;
            this.SLNRadBtn.Text = "Straight Line";
            this.SLNRadBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(405, 241);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(145, 37);
            this.UpdateBtn.TabIndex = 7;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitBtn.Location = new System.Drawing.Point(405, 296);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(145, 37);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // OutputListView
            // 
            this.OutputListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.OutputListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputListView.FullRowSelect = true;
            this.OutputListView.GridLines = true;
            this.OutputListView.HideSelection = false;
            this.OutputListView.Location = new System.Drawing.Point(16, 180);
            this.OutputListView.Name = "OutputListView";
            this.OutputListView.Size = new System.Drawing.Size(353, 153);
            this.OutputListView.TabIndex = 9;
            this.OutputListView.UseCompatibleStateImageBehavior = false;
            this.OutputListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Year";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Depreciation ";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 118;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Value";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 153;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Depreciation Schedule";
            // 
            // DepreciationCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 345);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OutputListView);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LifeTxtBox);
            this.Controls.Add(this.SalvageValueTxtBox);
            this.Controls.Add(this.InitialCostTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "DepreciationCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depreciation Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InitialCostTxtBox;
        private System.Windows.Forms.TextBox SalvageValueTxtBox;
        private System.Windows.Forms.TextBox LifeTxtBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SYDRadBtn;
        private System.Windows.Forms.RadioButton SLNRadBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.ListView OutputListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton DDBRadBtn;
        private System.Windows.Forms.RadioButton DBRadBtn;
    }
}

