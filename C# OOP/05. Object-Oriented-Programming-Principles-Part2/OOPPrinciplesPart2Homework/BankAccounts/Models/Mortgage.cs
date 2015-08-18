

namespace BankAccounts.Models
{
    using System;
    using BankAccounts.Interfaces;

    class Mortgage : Account, IDeposite
    {
        public Mortgage(Coustomer coustomer, decimal balance, decimal interestRate)
            :base (coustomer, balance, interestRate)
        {

        }

        public void DepositeMoney(decimal money)
        {
            if (money < 0)
                throw new ArgumentException("You cannot deposite negative amount of money!");
            this.Balance += money;
        }

        public override string CalculateIterest(decimal numberOfMonths)
        {
            if(Coustomer.GetType().Name.CompareTo("Individual") == 0)
            {
                if(numberOfMonths <= 6)
                {
                    return "Individuals have no interest for the first 6 months! ";
                }
                return ((numberOfMonths-6) * this.InterestRate).ToString();
            }
            else
            {
                if (numberOfMonths <= 12)
                {
                    return (numberOfMonths * (this.InterestRate * 0.5M)).ToString();
                }
                return (12 * ((this.InterestRate/100) * 0.5M)) + ((numberOfMonths - 12) * (this.InterestRate/ 100)).ToString();
            }
        }

        public override string ToString()
        {
            return string.Format("\n {0}: \n Name: {1} \n Balance: {2} \n Interest rate: {3}", "Mortgage", this.Coustomer.Name, this.Balance, this.InterestRate);
        }
    }
}
