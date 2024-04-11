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
    public partial class Form3 : Form
    {
        private static decimal balance = 10000;
        public Form3()
        {
            InitializeComponent();
        }
        public decimal Balance
        {
            get { return balance; }
        }

        public void UpdateBalance(decimal amount)
        {
            balance += amount;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void withdrawlbl_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4(this);
            this.Hide();
            newForm.ShowDialog();
        }

        private void CheckBalance_Click(object sender, EventArgs e)
        {
            Form5 newform5 = new Form5(this);
            this.Hide();
            newform5.ShowDialog();
            this.Close();
        }

        private void Depositlabel_Click(object sender, EventArgs e)
        {
            Form6 newform6 = new Form6(this);
            this.Hide();
            newform6.ShowDialog();
        }

        private void Paybillslabel_Click(object sender, EventArgs e)
        {
            Form8 newform7 = new Form8(this);
            this.Hide();
            newform7.ShowDialog();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 newform7 = new Form1();
            this.Hide();
            newform7.ShowDialog();
        }

        private void ChangePinlabel_Click(object sender, EventArgs e)
        {
            Form7 newform7 = new Form7();
            this.Hide();
            newform7.ShowDialog();
        }

    }
}
