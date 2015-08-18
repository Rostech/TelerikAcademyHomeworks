

namespace BankAccounts.Models
{
    using System;
    using BankAccounts.Interfaces;

    public class Deposite : Account, IDeposite, IWithDraw
    {
        public Deposite(Coustomer coustomer, decimal balance, decimal interestRate)
            : base(coustomer, balance, interestRate)
        {

        }

        public void DepositeMoney(decimal money)
        {
            if (money < 0)
                throw new ArgumentException("You cannot deposite negative amount of money!");
            this.Balance += money;

        }

        public void WithDrawMoney(decimal money)
        {
            if (money < 0)
                throw new ArgumentException("You cannot with draw negative amount of money!");
            this.Balance -= money;
        }

        public override string CalculateIterest(decimal numberOfMonths)
        {
            if (this.Balance < 1000)
                return string.Format("This coustomers ({0}) account have no interest amount!");
            return (numberOfMonths * (this.InterestRate / 100)).ToString();
        }

        public override string ToString()
        {
            return string.Format("\n {0}: \n Name: {1} \n Balance: {2} \n Interest rate: {3}","Deposite account", this.Coustomer.Name, this.Balance, this.InterestRate);
        }
    }
}
