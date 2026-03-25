namespace BankingApp
{
    public class InvestmentAccount : Account
    {
        double interestRate = 0.05;
        double failedFee = 10;

        public InvestmentAccount(string name, double balance) : base(name, balance)
        {
        }

        public override string Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                lastTransaction = "Withdrawal Successful";
            }
            else
            {
                Balance -= failedFee;
                lastTransaction = "Failed Transaction Fee Applied";
            }

            return lastTransaction;
        }

        public override void CalculateInterest()
        {
            Balance += Balance * interestRate;
        }
    }
}