﻿namespace TestProject
{
    public class CheckingAccount : Account
    {
        const double Fee = 1.5;
        public CheckingAccount(string name = "", double balance = 0) : base(name, balance)
        {

        }
        public override bool Withdraw( double amount)
        {
            return base. Withdraw(amount + Fee);
        }
    }
}
