namespace ATM
{
    partial class Form5
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
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.balancelabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.okaybtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(138, 12);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(218, 27);
            this.guna2HtmlLabel2.TabIndex = 9;
            this.guna2HtmlLabel2.Text = "ACCOUNT BALANCE";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(24)))));
            this.guna2CustomGradientPanel1.Controls.Add(this.balancelabel);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(1)))), ((int)(((byte)(32)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(1)))), ((int)(((byte)(32)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(1)))), ((int)(((byte)(32)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(1)))), ((int)(((byte)(32)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(118, 85);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(284, 147);
            this.guna2CustomGradientPanel1.TabIndex = 10;
            // 
            // balancelabel
            // 
            this.balancelabel.BackColor = System.Drawing.Color.Transparent;
            this.balancelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balancelabel.ForeColor = System.Drawing.Color.White;
            this.balancelabel.Location = new System.Drawing.Point(47, 61);
            this.balancelabel.Name = "balancelabel";
            this.balancelabel.Size = new System.Drawing.Size(65, 18);
            this.balancelabel.TabIndex = 1;
            this.balancelabel.Text = "BALANCE";
            this.balancelabel.Click += new System.EventHandler(this.balancelabel_Click);
            // 
            // okaybtn
            // 
            this.okaybtn.AutoRoundedCorners = true;
            this.okaybtn.BorderRadius = 14;
            this.okaybtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.okaybtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.okaybtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.okaybtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.okaybtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(1)))), ((int)(((byte)(32)))));
            this.okaybtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.okaybtn.ForeColor = System.Drawing.Color.White;
            this.okaybtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.okaybtn.Location = new System.Drawing.Point(228, 255);
            this.okaybtn.Name = "okaybtn";
            this.okaybtn.Size = new System.Drawing.Size(58, 31);
            this.okaybtn.TabIndex = 11;
            this.okaybtn.Text = "Okay";
            this.okaybtn.Click += new System.EventHandler(this.okaybtn_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(519, 341);
            this.Controls.Add(this.okaybtn);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel balancelabel;
        private Guna.UI2.WinForms.Guna2Button okaybtn;
    }
}