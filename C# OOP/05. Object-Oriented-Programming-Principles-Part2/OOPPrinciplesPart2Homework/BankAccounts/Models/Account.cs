

namespace BankAccounts.Models
{
    using System;

    public abstract class Account
    {
        private Coustomer coustomer;
        private decimal balance;
        private decimal interestRate;

        public Account(Coustomer coustomer, decimal balance, decimal interestRate)
        {
            this.Coustomer = coustomer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Coustomer Coustomer
        {
            get
            {
                return this.coustomer;
            }
            set
            {
                this.coustomer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Balance cannot be negative!");
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Interest rate cannot be negative!");
                this.interestRate = value;
            }
        }

        public abstract string CalculateIterest(decimal numberOfMonths);
    }
}
