using ProxyPattern.Interfaces;
using ProxyPattern.Proxies;
using ProxyPattern.Utils;
namespace ProxyPattern
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            IShoppingCart shoppingCart = new ShoppingCartProxy();

            Console.WriteLine("Content of the shopping cart. We are using Proxy. Yeah :)");
            
            shoppingCart.AddProduct(Product.Apple);
            shoppingCart.AddProduct(Product.Bread);
            shoppingCart.AddProduct(Product.Meat);
            shoppingCart.AddProduct(Product.Orange);
            shoppingCart.AddProduct(Product.Milk);
            shoppingCart.AddProduct(Product.ToiletPaper);

            Console.WriteLine(new string('-', 60));
            Console.WriteLine(shoppingCart.ListProducts());
            Console.WriteLine(new string('-', 60));
        }
    }
}
