

namespace BankAccounts.Models
{
    using System;
    using System.Collections.Generic;

    public class Bank
    {
        private string name;
        //private HashSet<Account> bankAccounts;
        private Dictionary<string, Account> bankAccounts;
        // TODO: 
        // dictonary .. proverka dali klienta s takava smetka go ima ako ne moje da go dobavim! i indeksaciq za dictionaryto

        public Bank(string name)
        {
            this.Name = name;
            bankAccounts = new Dictionary<string, Account>();
        }

        public Dictionary<string, Account> BankAccounts
        {
            get
            {
                return this.bankAccounts;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("The bank should have a name!");
                this.name = value;
            }
        }

        public void AddAccount(Account account)
        {
            bool addAcount = true;
            foreach (var item in this.BankAccounts)
            {
                if (item.Key == account.Coustomer.Name && item.Value.GetType().Name == account.GetType().Name)
                {
                    addAcount = false;
                    break;
                }
            }
            if (addAcount)
            {
                this.bankAccounts.Add(account.Coustomer.Name, account);
            }
            else
            {
                Console.WriteLine("This account already exists!");
            }
        }
        
        public void RemoveAccount(Account account)
        {
            this.bankAccounts.Remove(account.Coustomer.Name);
        }

        public override string ToString()
        {
            return string.Format("{0} Bank: \n {1}", this.name, string.Join("\n\n", this.BankAccounts));
        }
    }
}
