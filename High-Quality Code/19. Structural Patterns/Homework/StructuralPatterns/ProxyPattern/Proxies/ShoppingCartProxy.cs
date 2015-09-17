namespace ProxyPattern.Proxies
{
    using System;
    using System.Collections.Generic;

    using ProxyPattern.Utils;
    using ProxyPattern.Interfaces;
    using ProxyPattern.Models;

    internal class ShoppingCartProxy : IShoppingCart
    {
        private ShoppingCart shoppingCart = new ShoppingCart();

        public void AddProduct(Product product)
        {
            this.shoppingCart.AddProduct(product);
        }

        public string ListProducts()
        {
            return this.shoppingCart.ListProducts();
        }

        public void RemoveProduct(Product product)
        {
            this.shoppingCart.RemoveProduct(product);
        }
    }
}
