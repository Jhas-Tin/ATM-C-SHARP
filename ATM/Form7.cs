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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent(); 
        }

        public Form7(DateTime transactionDateTime, decimal paymentAmount, decimal totalBalance)
        {
            InitializeComponent();
            Datelbl.Text = transactionDateTime.ToShortDateString();
            Time.Text = transactionDateTime.ToLongTimeString();
            Amount.Text = "₱" + paymentAmount.ToString("N2"); ;
        }
        private void Electricbillbtn_Click(object sender, EventArgs e)
        {
        }

        private void Changepin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Datelbl_Click(object sender, EventArgs e)
        {

        }

        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void Amount_Click(object sender, EventArgs e)
        {

        }

        private void balancetotal_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Form3 newform6 = new Form3();
            this.Hide();
            newform6.ShowDialog();
            this.Close();
        }
    }
}
