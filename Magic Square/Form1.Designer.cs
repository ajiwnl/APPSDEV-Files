namespace Magic_Square
{
    partial class MagicSquare
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
            this.InputTxtBox = new System.Windows.Forms.TextBox();
            this.OutListBox = new System.Windows.Forms.ListBox();
            this.DisplayBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputTxtBox
            // 
            this.InputTxtBox.Location = new System.Drawing.Point(126, 12);
            this.InputTxtBox.Name = "InputTxtBox";
            this.InputTxtBox.Size = new System.Drawing.Size(100, 20);
            this.InputTxtBox.TabIndex = 0;
            // 
            // OutListBox
            // 
            this.OutListBox.FormattingEnabled = true;
            this.OutListBox.Location = new System.Drawing.Point(81, 131);
            this.OutListBox.Name = "OutListBox";
            this.OutListBox.Size = new System.Drawing.Size(197, 147);
            this.OutListBox.TabIndex = 2;
            // 
            // DisplayBtn
            // 
            this.DisplayBtn.Location = new System.Drawing.Point(124, 69);
            this.DisplayBtn.Name = "DisplayBtn";
            this.DisplayBtn.Size = new System.Drawing.Size(102, 29);
            this.DisplayBtn.TabIndex = 1;
            this.DisplayBtn.Text = "Display";
            this.DisplayBtn.UseVisualStyleBackColor = true;
            this.DisplayBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // MagicSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 290);
            this.Controls.Add(this.OutListBox);
            this.Controls.Add(this.DisplayBtn);
            this.Controls.Add(this.InputTxtBox);
            this.MaximizeBox = false;
            this.Name = "MagicSquare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magic Square";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTxtBox;
        private System.Windows.Forms.ListBox OutListBox;
        private System.Windows.Forms.Button DisplayBtn;
    }
}

