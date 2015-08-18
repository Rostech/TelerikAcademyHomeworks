namespace Cosmetics.Products
{
    using System.Collections.Generic;
    using System.Linq;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class ShoppingCart : IShoppingCart
    {
        private ICollection<IProduct> collection;

        public ShoppingCart()
        {
            this.collection = new List<IProduct>();
        }

        public ICollection<IProduct> Collection
        {
            get
            {
                return new List<IProduct>(this.collection);
            }
        }

        public void AddProduct(IProduct product)
        {
            Validator.CheckIfNull(product);
            this.collection.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            Validator.CheckIfNull(product);
            this.collection.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            Validator.CheckIfNull(product);
            var ifContains =
                this.collection.FirstOrDefault(p => p.Name.CompareTo(product.Name) == 0);
            if(ifContains != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal TotalPrice()
        {
            decimal result = this.collection.Sum(c => c.Price);
            return result;
        }
    }
}
