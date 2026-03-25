namespace BankingApp
{
    public class EverydayAccount : Account
    {
        public EverydayAccount(string name, double balance) : base(name, balance)
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
                lastTransaction = "No Overdraft Allowed";
            }

            return lastTransaction;
        }
    }
}