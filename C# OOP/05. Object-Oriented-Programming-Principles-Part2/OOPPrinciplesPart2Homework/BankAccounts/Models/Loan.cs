
namespace BankAccounts.Models
{
    using System;
    using BankAccounts.Interfaces;


    class Loan : Account, IDeposite
    {

        public Loan(Coustomer coustomer, decimal balance, decimal interestRate)
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
                if(numberOfMonths <= 3)
                {
                    return "Individuals have no interest for the first 3 months! ";
                }
                return ((numberOfMonths-3) * (this.InterestRate / 100)).ToString();
            }
            else
            {
                if (numberOfMonths <= 2)
                {
                    return "Companies have no interest for the first 2 months! ";
                }
                return ((numberOfMonths - 2) * this.InterestRate).ToString();
            }
        }

        public override string ToString()
        {
            return string.Format("\n {0}: \n Name: {1} \n Balance: {2} \n Interest rate: {3}", "Loan", this.Coustomer.Name, this.Balance, this.InterestRate);
        }

    }
}
