
namespace Extension_Delegates_AndOther
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /*
     . Divisible by 7 and 3

        Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

    */
    class DevisibleBy7And3
    {
        public static IEnumerable<int> DevisibleBy7and3(int[] arr)
        {
            // lambda expression
            var result = arr.
                Where(num => num % 7 == 0 && num % 3 == 0);
            // LINQ query
            var rslt =
                from num in arr
                where num % 7 == 0 && num % 3 == 0
                select num;

            return result;
        }
    }
}
