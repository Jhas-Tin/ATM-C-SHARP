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
    public partial class Form5 : Form
    {
        private Form3 form3Ref;
        public Form5(Form3 form3)
        {
            InitializeComponent();
            form3Ref = form3;
            DisplayBalance();
        }
        private void DisplayBalance()
        {
            balancelabel.Text = $"Current Balance: {form3Ref.Balance:C}";
        }

        private void balancelabel_Click(object sender, EventArgs e)
        {

        }

        private void okaybtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }
    }
}
