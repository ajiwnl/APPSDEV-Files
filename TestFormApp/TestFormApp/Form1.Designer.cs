namespace TestFormApp
{
    partial class TestFormApp
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
            this.DisplayBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.FormLbl = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.TextBoxLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DisplayBtn
            // 
            this.DisplayBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.DisplayBtn.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayBtn.Location = new System.Drawing.Point(82, 137);
            this.DisplayBtn.Name = "DisplayBtn";
            this.DisplayBtn.Size = new System.Drawing.Size(121, 41);
            this.DisplayBtn.TabIndex = 0;
            this.DisplayBtn.Text = "Display";
            this.DisplayBtn.UseVisualStyleBackColor = false;
            this.DisplayBtn.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(199, 6);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // FormLbl
            // 
            this.FormLbl.AutoSize = true;
            this.FormLbl.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormLbl.ForeColor = System.Drawing.Color.IndianRed;
            this.FormLbl.Location = new System.Drawing.Point(68, 54);
            this.FormLbl.Name = "FormLbl";
            this.FormLbl.Size = new System.Drawing.Size(150, 21);
            this.FormLbl.TabIndex = 2;
            this.FormLbl.Text = "Sample Form App";
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(185, 98);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(75, 20);
            this.TextBox.TabIndex = 3;
            // 
            // TextBoxLbl
            // 
            this.TextBoxLbl.AutoSize = true;
            this.TextBoxLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLbl.Location = new System.Drawing.Point(69, 101);
            this.TextBoxLbl.Name = "TextBoxLbl";
            this.TextBoxLbl.Size = new System.Drawing.Size(114, 17);
            this.TextBoxLbl.TabIndex = 4;
            this.TextBoxLbl.Text = "Enter your name:";
            // 
            // TestFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(286, 234);
            this.Controls.Add(this.TextBoxLbl);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.FormLbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.DisplayBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TestFormApp";
            this.Text = "Test Form App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DisplayBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label FormLbl;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label TextBoxLbl;
    }
}

