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
    public partial class Form6 : Form
    {
        private Form3 form3Ref;

        public Form6(Form3 form3)
        {
            InitializeComponent();
            form3Ref = form3;
        }

        private void okaybtn_Click(object sender, EventArgs e)
        {
            decimal depositAmount;

            if (decimal.TryParse(Deposittxt.Text, out depositAmount) && depositAmount > 0)
            {
                if (AllowedBill(depositAmount))
                {
                    form3Ref.UpdateBalance(+depositAmount);
                    MessageBox.Show($"Deposit successful.");

                    DateTime transactionDateTime = DateTime.Now;

                    Form7 newForm7 = new Form7(transactionDateTime, depositAmount, form3Ref.Balance);

                    this.Hide();

                    newForm7.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid deposit amount. Please enter a valid bill.");
                }
            }
            else
            {
                MessageBox.Show("Invalid deposit amount. Please enter a valid amount.");
            }
        }
        private bool AllowedBill(decimal amount)
        {
            decimal[] allowedBills = { 20, 50, 100, 200, 500, 1000 };

            Array.Sort(allowedBills);
            Array.Reverse(allowedBills);

            foreach (decimal bill in allowedBills)
            {
                if (amount >= bill)
                {
                    decimal remainder = amount % bill;
                    if (remainder == 0 || AllowedBill(remainder))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form3 newform6 = new Form3();
            this.Hide();
            newform6.ShowDialog();
        }
    }
}
