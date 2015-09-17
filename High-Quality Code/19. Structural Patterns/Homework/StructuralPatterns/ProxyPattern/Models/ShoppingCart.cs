namespace ProxyPattern.Models
{
    using System.Collections.Generic;
    using System.Text;

    using ProxyPattern.Utils;
    using ProxyPattern.Interfaces;

    internal class ShoppingCart : IShoppingCart
    {
        internal List<Product> products;

        internal ShoppingCart()
        {
            this.products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public string ListProducts()
        {
            StringBuilder shoppingCartContent = new StringBuilder();
            for(var i = 0; i < this.products.Count; i++)
            {
                shoppingCartContent.AppendLine(this.products[i].ToString());
            }

            return shoppingCartContent.ToString();
        }

        public void RemoveProduct(Product product)
        {
            this.products.Remove(product);
        }
    }
}
