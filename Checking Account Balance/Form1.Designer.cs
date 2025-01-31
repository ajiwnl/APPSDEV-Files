namespace Checking_Account_Balance
{
    partial class CheckAcctBalanceForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ServiceChargeRadBtn = new System.Windows.Forms.RadioButton();
            this.CheckRadBtn = new System.Windows.Forms.RadioButton();
            this.DepRadBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.InputAmtTxtBox = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SummaryBtn = new System.Windows.Forms.Button();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NewBalanceLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NoDepLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DepositLbl = new System.Windows.Forms.Label();
            this.NoCheckLbl = new System.Windows.Forms.Label();
            this.CheckLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ServiceChargeRadBtn);
            this.groupBox1.Controls.Add(this.CheckRadBtn);
            this.groupBox1.Controls.Add(this.DepRadBtn);
            this.groupBox1.Location = new System.Drawing.Point(78, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Type";
            // 
            // ServiceChargeRadBtn
            // 
            this.ServiceChargeRadBtn.AutoSize = true;
            this.ServiceChargeRadBtn.Location = new System.Drawing.Point(19, 108);
            this.ServiceChargeRadBtn.Name = "ServiceChargeRadBtn";
            this.ServiceChargeRadBtn.Size = new System.Drawing.Size(98, 17);
            this.ServiceChargeRadBtn.TabIndex = 2;
            this.ServiceChargeRadBtn.TabStop = true;
            this.ServiceChargeRadBtn.Text = "Service Charge";
            this.ServiceChargeRadBtn.UseVisualStyleBackColor = true;
            // 
            // CheckRadBtn
            // 
            this.CheckRadBtn.AutoSize = true;
            this.CheckRadBtn.Location = new System.Drawing.Point(19, 70);
            this.CheckRadBtn.Name = "CheckRadBtn";
            this.CheckRadBtn.Size = new System.Drawing.Size(56, 17);
            this.CheckRadBtn.TabIndex = 1;
            this.CheckRadBtn.TabStop = true;
            this.CheckRadBtn.Text = "Check";
            this.CheckRadBtn.UseVisualStyleBackColor = true;
            // 
            // DepRadBtn
            // 
            this.DepRadBtn.AutoSize = true;
            this.DepRadBtn.Location = new System.Drawing.Point(19, 32);
            this.DepRadBtn.Name = "DepRadBtn";
            this.DepRadBtn.Size = new System.Drawing.Size(61, 17);
            this.DepRadBtn.TabIndex = 0;
            this.DepRadBtn.TabStop = true;
            this.DepRadBtn.Text = "Deposit";
            this.DepRadBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Amount";
            // 
            // InputAmtTxtBox
            // 
            this.InputAmtTxtBox.Location = new System.Drawing.Point(325, 35);
            this.InputAmtTxtBox.Name = "InputAmtTxtBox";
            this.InputAmtTxtBox.Size = new System.Drawing.Size(100, 20);
            this.InputAmtTxtBox.TabIndex = 2;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClearBtn.Location = new System.Drawing.Point(443, 227);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Location = new System.Drawing.Point(349, 275);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SummaryBtn
            // 
            this.SummaryBtn.BackColor = System.Drawing.Color.Coral;
            this.SummaryBtn.Location = new System.Drawing.Point(349, 227);
            this.SummaryBtn.Name = "SummaryBtn";
            this.SummaryBtn.Size = new System.Drawing.Size(75, 23);
            this.SummaryBtn.TabIndex = 5;
            this.SummaryBtn.Text = "Summary";
            this.SummaryBtn.UseVisualStyleBackColor = false;
            this.SummaryBtn.Click += new System.EventHandler(this.SummaryBtn_Click);
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.BackColor = System.Drawing.Color.Lime;
            this.CalculateBtn.Location = new System.Drawing.Point(244, 229);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(75, 23);
            this.CalculateBtn.TabIndex = 6;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = false;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "New Balance";
            // 
            // NewBalanceLbl
            // 
            this.NewBalanceLbl.AutoSize = true;
            this.NewBalanceLbl.BackColor = System.Drawing.Color.LimeGreen;
            this.NewBalanceLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NewBalanceLbl.Location = new System.Drawing.Point(326, 71);
            this.NewBalanceLbl.Name = "NewBalanceLbl";
            this.NewBalanceLbl.Size = new System.Drawing.Size(2, 15);
            this.NewBalanceLbl.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total Number of Deposits";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Deposit Total Amount";
            this.label4.Visible = false;
            // 
            // NoDepLbl
            // 
            this.NoDepLbl.AutoSize = true;
            this.NoDepLbl.Location = new System.Drawing.Point(134, 23);
            this.NoDepLbl.Name = "NoDepLbl";
            this.NoDepLbl.Size = new System.Drawing.Size(0, 13);
            this.NoDepLbl.TabIndex = 11;
            this.NoDepLbl.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Check Total Amount";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total Number of Checks";
            this.label7.Visible = false;
            // 
            // DepositLbl
            // 
            this.DepositLbl.AutoSize = true;
            this.DepositLbl.Location = new System.Drawing.Point(134, 46);
            this.DepositLbl.Name = "DepositLbl";
            this.DepositLbl.Size = new System.Drawing.Size(0, 13);
            this.DepositLbl.TabIndex = 14;
            this.DepositLbl.Visible = false;
            // 
            // NoCheckLbl
            // 
            this.NoCheckLbl.AutoSize = true;
            this.NoCheckLbl.Location = new System.Drawing.Point(134, 69);
            this.NoCheckLbl.Name = "NoCheckLbl";
            this.NoCheckLbl.Size = new System.Drawing.Size(0, 13);
            this.NoCheckLbl.TabIndex = 15;
            this.NoCheckLbl.Visible = false;
            // 
            // CheckLbl
            // 
            this.CheckLbl.AutoSize = true;
            this.CheckLbl.Location = new System.Drawing.Point(134, 92);
            this.CheckLbl.Name = "CheckLbl";
            this.CheckLbl.Size = new System.Drawing.Size(0, 13);
            this.CheckLbl.TabIndex = 16;
            this.CheckLbl.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.NoDepLbl);
            this.groupBox2.Controls.Add(this.DepositLbl);
            this.groupBox2.Controls.Add(this.CheckLbl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.NoCheckLbl);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(242, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 112);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Summary";
            // 
            // CheckAcctBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 305);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.NewBalanceLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.SummaryBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.InputAmtTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CheckAcctBalanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checking Account Balance";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ServiceChargeRadBtn;
        private System.Windows.Forms.RadioButton CheckRadBtn;
        private System.Windows.Forms.RadioButton DepRadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputAmtTxtBox;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button SummaryBtn;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NewBalanceLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NoDepLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label DepositLbl;
        private System.Windows.Forms.Label NoCheckLbl;
        private System.Windows.Forms.Label CheckLbl;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

