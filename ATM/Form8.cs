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
    public partial class Form8 : Form
    {
        private Form3 form3Ref;
        public Form8(Form3 form3)
        {
            InitializeComponent();
            form3Ref = form3;
        }

        private void okaybtn_Click(object sender, EventArgs e)
        {
            decimal paymentAmount;

            if (decimal.TryParse(Deposittxt.Text, out paymentAmount))
            {
                if (IsAllowedBill(paymentAmount))
                {
                    if (paymentAmount > 0)
                    {
                        if (paymentAmount <= form3Ref.Balance)
                        {
                            form3Ref.UpdateBalance(-paymentAmount);

                            string selectedBill = PaybillSelection.SelectedItem.ToString();
                            MessageBox.Show($"Payment of {paymentAmount:C} for {selectedBill} successful.");

                            DateTime transactionDateTime = DateTime.Now;

                            Form7 newForm7 = new Form7(transactionDateTime, paymentAmount, form3Ref.Balance);

                            this.Hide();
                            newForm7.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("You do not have enough balance to make this payment.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid payment amount.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid payment amount. Please enter a valid bill.");
                }
            }
            else
            {
                MessageBox.Show("Invalid payment amount. Please enter a valid amount.");
            }
        }
        private bool IsAllowedBill(decimal amount)
        {
            decimal[] allowedBills = { 20, 50, 100, 200, 500, 1000 };

            Array.Sort(allowedBills);
            Array.Reverse(allowedBills);

            foreach (decimal bill in allowedBills)
            {
                if (amount >= bill)
                {
                    decimal remainder = amount % bill;
                    if (remainder == 0 || IsAllowedBill(remainder))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool IsAllowedBill(string bill)
        {
            List<string> allowedBills = new List<string> { "Electric Bill", "Water Bill", "Credit Card", "Loan" };

            return allowedBills.Contains(bill);
        }

        private void Deposittxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form3 newform6 = new Form3();
            this.Hide();
            newform6.Show();
        }

        private void PaybillSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PaybillSelection.SelectedItem != null)
            {
                if (PaybillSelection.SelectedItem.ToString() == "Electric Bill")
                {
                    choicecb.Visible = true;
                    InitializeElectricBillChoices();
                }
                else if (PaybillSelection.SelectedItem.ToString() == "Water Bill")
                {
                    choicecb.Visible = true;
                    InitializeWaterBillChoices();
                }
                else if (PaybillSelection.SelectedItem.ToString() == "Credit Card")
                {
                    choicecb.Visible = true;
                    InitializeCreditCardBillChoices();
                }
                else if (PaybillSelection.SelectedItem.ToString() == "Loan")
                {
                    choicecb.Visible = true;
                    InitializeLoanBillChoices();
                }
                else
                {
                    choicecb.Visible = false;
                }
            }
            else
            {
                choicecb.Visible = false;
            }
        }
        private void InitializeCreditCardBillChoices()
        {
            choicecb.Items.Clear();
            choicecb.Items.Add("MasterCard");
            choicecb.Items.Add("Visa");
        }
        private void InitializeLoanBillChoices()
        {
            choicecb.Items.Clear();
            choicecb.Items.Add("Esquire Financing");
            choicecb.Items.Add("Radiowealth Finance");
        }
        private void InitializeWaterBillChoices()
        {
            choicecb.Items.Clear();
            choicecb.Items.Add("MANILA WATER COMPANY, INC.");
            choicecb.Items.Add("PRIMEWATER INFRASTRUCTURE CORP.");
        }

        private void InitializeElectricBillChoices()
        {
            choicecb.Items.Clear();
            choicecb.Items.Add("Meralco");
            choicecb.Items.Add("Pelco");
        }

        private void choicecb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
