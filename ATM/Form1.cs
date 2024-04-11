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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Picturebtn_Click(object sender, EventArgs e)
        {
            if (Atmnumtxt.Text == "0000")
            {
                // Open a new form
                Form2 newForm = new Form2();
                this.Hide();
                newForm.Show();
            }
            else
            {
                // Show a message indicating invalid card number
                MessageBox.Show("Invalid card number.");
            }
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
