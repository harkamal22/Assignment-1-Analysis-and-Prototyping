namespace BankingApp
{
    public abstract class Account
    {
        public string AccountName { get; set; }
        public double Balance { get; set; }

        protected string lastTransaction = "";

        public Account(string name, double balance)
        {
            AccountName = name;
            Balance = balance;
        }

        public virtual string Deposit(double amount)
        {
            Balance += amount;
            lastTransaction = "Deposit Successful";
            return lastTransaction;
        }

        public virtual string Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                lastTransaction = "Withdrawal Successful";
            }
            else
            {
                lastTransaction = "Insufficient Funds";
            }

            return lastTransaction;
        }

        public virtual void CalculateInterest()
        {
        }

        public virtual string GetAccountInfo()
        {
            return "Account: " + AccountName +
                   "\nBalance: " + Balance +
                   "\nLast Transaction: " + lastTransaction;
        }
    }
}