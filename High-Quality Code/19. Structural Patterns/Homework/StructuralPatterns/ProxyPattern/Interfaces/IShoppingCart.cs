namespace ProxyPattern.Interfaces
{
    using System.Collections.Generic;
    using ProxyPattern.Utils;

    internal interface IShoppingCart
    {
        void AddProduct(Product product);

        void RemoveProduct(Product product);

        string ListProducts();
    }
}
