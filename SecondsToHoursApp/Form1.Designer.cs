namespace SecondsToHoursApp
{
    partial class SecondsConverter
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SecondsIntxtBox = new System.Windows.Forms.TextBox();
            this.HrsOuttxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MinsOuttxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SecsOuttxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Location = new System.Drawing.Point(131, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "CONVERT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Hours in Seconds:";
            // 
            // SecondsIntxtBox
            // 
            this.SecondsIntxtBox.Location = new System.Drawing.Point(220, 54);
            this.SecondsIntxtBox.Name = "SecondsIntxtBox";
            this.SecondsIntxtBox.Size = new System.Drawing.Size(125, 20);
            this.SecondsIntxtBox.TabIndex = 2;
            // 
            // HrsOuttxtBox
            // 
            this.HrsOuttxtBox.Enabled = false;
            this.HrsOuttxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HrsOuttxtBox.Location = new System.Drawing.Point(35, 100);
            this.HrsOuttxtBox.Multiline = true;
            this.HrsOuttxtBox.Name = "HrsOuttxtBox";
            this.HrsOuttxtBox.Size = new System.Drawing.Size(36, 31);
            this.HrsOuttxtBox.TabIndex = 3;
            this.HrsOuttxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "HRS.";
            // 
            // MinsOuttxtBox
            // 
            this.MinsOuttxtBox.Enabled = false;
            this.MinsOuttxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinsOuttxtBox.Location = new System.Drawing.Point(137, 100);
            this.MinsOuttxtBox.Multiline = true;
            this.MinsOuttxtBox.Name = "MinsOuttxtBox";
            this.MinsOuttxtBox.Size = new System.Drawing.Size(36, 31);
            this.MinsOuttxtBox.TabIndex = 5;
            this.MinsOuttxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "MINS.";
            // 
            // SecsOuttxtBox
            // 
            this.SecsOuttxtBox.Enabled = false;
            this.SecsOuttxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecsOuttxtBox.Location = new System.Drawing.Point(246, 100);
            this.SecsOuttxtBox.Multiline = true;
            this.SecsOuttxtBox.Name = "SecsOuttxtBox";
            this.SecsOuttxtBox.Size = new System.Drawing.Size(36, 31);
            this.SecsOuttxtBox.TabIndex = 7;
            this.SecsOuttxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "SECS.";
            // 
            // SecondsConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(385, 250);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SecsOuttxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MinsOuttxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HrsOuttxtBox);
            this.Controls.Add(this.SecondsIntxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(412, 289);
            this.Name = "SecondsConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seconds to Hours Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SecondsIntxtBox;
        private System.Windows.Forms.TextBox HrsOuttxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MinsOuttxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SecsOuttxtBox;
        private System.Windows.Forms.Label label4;
    }
}

