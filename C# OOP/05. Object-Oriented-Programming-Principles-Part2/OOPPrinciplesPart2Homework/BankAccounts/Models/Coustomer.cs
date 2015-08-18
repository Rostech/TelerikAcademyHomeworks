
namespace BankAccounts.Models
{
    using System;

    public abstract class Coustomer
    {
        private string name;

        public Coustomer(string name)
        {
            this.Name = name;
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
                    throw new ArgumentException("Coustomer shoud have a name!");
                this.name = value;
            }
        }
    }
}
