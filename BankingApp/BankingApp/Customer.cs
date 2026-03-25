using System.Collections.Generic;

namespace BankingApp
{
    public class Customer
    {
        public int CustomerNumber { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public bool IsStaff { get; set; }

        public List<Account> Accounts { get; set; }

        public Customer(int number, string name, string contact, bool staff)
        {
            CustomerNumber = number;
            Name = name;
            Contact = contact;
            IsStaff = staff;

            Accounts = new List<Account>();

            Accounts.Add(new EverydayAccount("Everyday Account", 500));
            Accounts.Add(new InvestmentAccount("Investment Account", 1000));
            Accounts.Add(new OmniAccount("Omni Account", 2000));
        }

        public Account GetAccount(int index)
        {
            return Accounts[index];
        }
    }
}