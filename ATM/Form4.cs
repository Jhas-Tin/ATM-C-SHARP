﻿using System;
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
    public partial class Form4 : Form
    {
        private Form3 form3Ref;
        public Form4(Form3 form3)
        {
            InitializeComponent();
            form3Ref = form3;
        }

        private void Withdrawtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void okaybtn_Click(object sender, EventArgs e)
        {
            decimal withdrawalAmount;

            if (decimal.TryParse(Withdrawtxt.Text, out withdrawalAmount))
            {
                if (IsAllowedBill(withdrawalAmount))
                {
                    if (withdrawalAmount > 0)
                    {
                        if (!(Withdrawtxt.Text.StartsWith("0") && Withdrawtxt.Text.Length > 1))
                        {
                            if (withdrawalAmount > form3Ref.Balance)
                            {
                                MessageBox.Show("You do not have enough balance to withdraw this amount.");
                            }
                            else
                            {
                                form3Ref.UpdateBalance(-withdrawalAmount);
                                MessageBox.Show($"Withdraw successful.");
                                DateTime transactionDateTime = DateTime.Now;

                                Form7 newForm7 = new Form7(transactionDateTime, withdrawalAmount, form3Ref.Balance);

                                this.Hide();

                                newForm7.ShowDialog();

                                this.Close();
                                form3Ref.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid withdrawal amount. Please enter a valid amount.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid withdrawal amount.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid withdrawal amount. Please enter a valid bill.");
                }
            }
            else
            {
                MessageBox.Show("Invalid withdrawal amount. Please enter a valid amount.");
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form3 newform6 = new Form3();
            this.Hide();
            newform6.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
