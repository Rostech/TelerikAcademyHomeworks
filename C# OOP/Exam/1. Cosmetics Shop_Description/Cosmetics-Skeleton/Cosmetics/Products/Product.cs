namespace Cosmetics.Products
{

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    
    public abstract class Product : IProduct
    {

        private const int ErrorNameMax = 10;
        private const int ErrorNameMin = 3;
        private const int ErrorBrandMax = 10;
        private const int ErrorBrandMin = 2;

        private string name;
        private string brand;
        private decimal price;
        private Common.GenderType gender;
        
        public Product(string name, string brand, decimal price, Common.GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value);
                Validator.CheckIfStringLengthIsValid(value, ErrorNameMax, ErrorNameMin, string.Format("Product name must be between {0} and {1} symbols long!", ErrorNameMin, ErrorNameMax));
                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value);
                Validator.CheckIfStringLengthIsValid(value, ErrorBrandMax, ErrorBrandMin, string.Format("Product brand must be between {0} and {1} symbols long!", ErrorBrandMin, ErrorBrandMax));
                this.brand = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                this.price = value;
            }
        }

        public Common.GenderType Gender
        {
            get
            {
                return this.gender;
            }
            private set
            {
                this.gender = value;
            }
        }

        public string Print()
        {
            return string.Empty;
        }
    }
}
