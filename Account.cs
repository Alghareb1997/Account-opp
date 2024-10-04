using System.Security.AccessControl;

namespace TestProject
{
    public class Account
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public Account(string name = "", double balance = 0)
        {
            Name = name;
            Balance = balance;
        }
        public static Account operator +(Account a, Account b)
        {
            Account account = new Account() { Name = a.Name, Balance = a.Balance + b.Balance };
            return account;
        }
        public virtual bool Withdraw(double amount)
        {
            if (Balance > amount)
            {
                Balance -= amount;
                return true;
            }
           return false;
        }

        public virtual bool Deposit(double amount)
        {
            Balance += amount;
            return true;

        }
    }
}
