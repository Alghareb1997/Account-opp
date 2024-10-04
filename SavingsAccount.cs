namespace TestProject
{
    public class SavingsAccount : Account
    {
        public double Rate { get; set; }
        public SavingsAccount(string name = "", int balance = 0, double rate = 0) : base(name, balance)
        {
            Rate = rate;
        }
    }
}
