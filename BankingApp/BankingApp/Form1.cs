using System;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class Form1 : Form
    {
        Customer customer;

        public Form1()
        {
            InitializeComponent();

            // Create customer with accounts
            customer = new Customer(1, "Aman", "021234567", false);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(txtAmount.Text);

            Account acc = customer.GetAccount(comboAccount.SelectedIndex);

            string result = acc.Deposit(amount);

            txtResult.Text = result + "\r\n" + acc.GetAccountInfo();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(txtAmount.Text);

            Account acc = customer.GetAccount(comboAccount.SelectedIndex);

            string result = acc.Withdraw(amount);

            txtResult.Text = result + "\r\n" + acc.GetAccountInfo();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Account acc = customer.GetAccount(comboAccount.SelectedIndex);

            txtResult.Text = acc.GetAccountInfo();
        }
    }
}