using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private string pin = "";
        private void Picturebtn_Click(object sender, EventArgs e)
        {
            if (pin == "010101")
            {
                // Open a new form
                Form3 newForm = new Form3();
                this.Hide();
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid PIN. Please enter the correct PIN");
            }
        }

        private void Atmnumtxt_TextChanged(object sender, EventArgs e)
        {
            pin = Atmnumtxt.Text;
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
