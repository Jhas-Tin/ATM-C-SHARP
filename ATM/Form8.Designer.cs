namespace ATM
{
    partial class Form8
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.okaybtn = new Guna.UI2.WinForms.Guna2Button();
            this.Deposittxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.withdrawlbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PaybillSelection = new Guna.UI2.WinForms.Guna2ComboBox();
            this.choicecb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(1)))), ((int)(((byte)(32)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(255, 253);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(65, 33);
            this.guna2Button1.TabIndex = 22;
            this.guna2Button1.Text = "Cancel";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // okaybtn
            // 
            this.okaybtn.AutoRoundedCorners = true;
            this.okaybtn.BorderRadius = 15;
            this.okaybtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.okaybtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.okaybtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.okaybtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.okaybtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(1)))), ((int)(((byte)(32)))));
            this.okaybtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.okaybtn.ForeColor = System.Drawing.Color.White;
            this.okaybtn.Location = new System.Drawing.Point(173, 253);
            this.okaybtn.Name = "okaybtn";
            this.okaybtn.Size = new System.Drawing.Size(65, 33);
            this.okaybtn.TabIndex = 21;
            this.okaybtn.Text = "Okay";
            this.okaybtn.Click += new System.EventHandler(this.okaybtn_Click);
            // 
            // Deposittxt
            // 
            this.Deposittxt.AutoRoundedCorners = true;
            this.Deposittxt.BorderRadius = 15;
            this.Deposittxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Deposittxt.DefaultText = "";
            this.Deposittxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Deposittxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Deposittxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Deposittxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Deposittxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(1)))), ((int)(((byte)(32)))));
            this.Deposittxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Deposittxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Deposittxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Deposittxt.Location = new System.Drawing.Point(110, 199);
            this.Deposittxt.Name = "Deposittxt";
            this.Deposittxt.PasswordChar = '\0';
            this.Deposittxt.PlaceholderText = "";
            this.Deposittxt.SelectedText = "";
            this.Deposittxt.Size = new System.Drawing.Size(265, 33);
            this.Deposittxt.TabIndex = 20;
            this.Deposittxt.TextChanged += new System.EventHandler(this.Deposittxt_TextChanged);
            // 
            // withdrawlbl
            // 
            this.withdrawlbl.BackColor = System.Drawing.Color.Transparent;
            this.withdrawlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawlbl.ForeColor = System.Drawing.Color.White;
            this.withdrawlbl.Location = new System.Drawing.Point(110, 171);
            this.withdrawlbl.Name = "withdrawlbl";
            this.withdrawlbl.Size = new System.Drawing.Size(60, 22);
            this.withdrawlbl.TabIndex = 18;
            this.withdrawlbl.Text = "Amount";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(194, 25);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(111, 27);
            this.guna2HtmlLabel2.TabIndex = 19;
            this.guna2HtmlLabel2.Text = "PAY BILLS";
            // 
            // PaybillSelection
            // 
            this.PaybillSelection.AutoRoundedCorners = true;
            this.PaybillSelection.BackColor = System.Drawing.Color.Transparent;
            this.PaybillSelection.BorderRadius = 17;
            this.PaybillSelection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PaybillSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaybillSelection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(1)))), ((int)(((byte)(32)))));
            this.PaybillSelection.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PaybillSelection.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PaybillSelection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PaybillSelection.ForeColor = System.Drawing.Color.White;
            this.PaybillSelection.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.PaybillSelection.ItemHeight = 30;
            this.PaybillSelection.Items.AddRange(new object[] {
            "Electric Bill",
            "Water Bill",
            "Credit Card",
            "Loan"});
            this.PaybillSelection.Location = new System.Drawing.Point(104, 119);
            this.PaybillSelection.Name = "PaybillSelection";
            this.PaybillSelection.Size = new System.Drawing.Size(134, 36);
            this.PaybillSelection.TabIndex = 23;
            this.PaybillSelection.SelectedIndexChanged += new System.EventHandler(this.PaybillSelection_SelectedIndexChanged);
            // 
            // choicecb
            // 
            this.choicecb.AutoRoundedCorners = true;
            this.choicecb.BackColor = System.Drawing.Color.Transparent;
            this.choicecb.BorderRadius = 17;
            this.choicecb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.choicecb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choicecb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(1)))), ((int)(((byte)(32)))));
            this.choicecb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.choicecb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.choicecb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.choicecb.ForeColor = System.Drawing.Color.White;
            this.choicecb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.choicecb.ItemHeight = 30;
            this.choicecb.Items.AddRange(new object[] {
            "Electric Bill",
            "Water Bill"});
            this.choicecb.Location = new System.Drawing.Point(255, 119);
            this.choicecb.Name = "choicecb";
            this.choicecb.Size = new System.Drawing.Size(138, 36);
            this.choicecb.TabIndex = 24;
            this.choicecb.SelectedIndexChanged += new System.EventHandler(this.choicecb_SelectedIndexChanged);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(510, 361);
            this.Controls.Add(this.choicecb);
            this.Controls.Add(this.PaybillSelection);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.okaybtn);
            this.Controls.Add(this.Deposittxt);
            this.Controls.Add(this.withdrawlbl);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button okaybtn;
        private Guna.UI2.WinForms.Guna2TextBox Deposittxt;
        private Guna.UI2.WinForms.Guna2HtmlLabel withdrawlbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox PaybillSelection;
        private Guna.UI2.WinForms.Guna2ComboBox choicecb;
    }
}