namespace BankingApp
{
    public class OmniAccount : Account
    {
        double interestRate = 0.04;
        double overdraft = 500;
        double failedFee = 10;

        public OmniAccount(string name, double balance) : base(name, balance)
        {
        }

        public override string Withdraw(double amount)
        {
            if (Balance + overdraft >= amount)
            {
                Balance -= amount;
                lastTransaction = "Withdrawal Successful";
            }
            else
            {
                Balance -= failedFee;
                lastTransaction = "Overdraft Limit Exceeded - Fee Charged";
            }

            return lastTransaction;
        }

        public override void CalculateInterest()
        {
            if (Balance > 1000)
            {
                Balance += Balance * interestRate;
            }
        }
    }
}