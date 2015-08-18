namespace Cosmetics.Products
{
    using System.Text;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Shampoo : Product, IShampoo, IProduct
    {
        private uint milliliters;
        private UsageType usage;
        
        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            :base(name, brand, price * milliliters, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public uint Milliliters
        {
            get
            {
                return this.milliliters;
            }
            private set
            {
                this.milliliters = value;
            }
        }

        public UsageType Usage
        {
            get
            {
                return this.usage;
            }
            private set
            {
                this.usage = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("\n- {0} - {1}:", base.Brand, base.Name));
            result.AppendLine(string.Format("  * Price: ${0}", base.Price));
            result.AppendLine(string.Format("  * For gender: {0}", base.Gender));
            result.AppendLine(string.Format("  * Quantity: {0} ml", this.Milliliters));
            result.Append(string.Format("  * Usage: {0}", this.Usage));

            return result.ToString();
        }
    }
}
