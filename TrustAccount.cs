using System.ComponentModel.Design;

namespace TestProject
{
    public class TrustAccount : SavingsAccount
    {
        public TrustAccount(string name = "", int balance = 0, double rate = 0)
            : base(name, balance, rate)
        {

        }
        public bool Depoist(double amount)
        {
            if (amount > 5000)
            {
                Balance += amount + 50;
                return true;
            }
            else
            {
                Balance += amount;
            }
            return false;

        }
        public  bool Withdraw(double amount)
        {
            double percent = 0.2 * Balance;
            int counter = 0;
            DateTime date = DateTime.Now;
            DateTime date2 = DateTime.Now;
            date2.AddYears(1);
            if (amount < percent & date < date2 & counter < 3)
            {
                Balance -= amount;
                counter++;
                return true;
            }
            else
                return false;

        }
        public bool Deposit(double amount)
        {
            if(amount>5000)
            {
                Balance += amount +50;
                return true;
            }

            else
            {
                Balance += amount;
                return true;
            }
            return false;
                
        }

    }
}
