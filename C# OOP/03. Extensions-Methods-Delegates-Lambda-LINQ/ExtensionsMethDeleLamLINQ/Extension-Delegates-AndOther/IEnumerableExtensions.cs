

namespace Extension_Delegates_AndOther
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /*
     2. IEnumerable extensions

        Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

    */
    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> set) where T : struct
        {
            T sum = (dynamic)set.Sum(x => (dynamic)x);
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> set) where T : struct
        {
            T product = (dynamic)1;
            foreach(var s in set)
            {
                product *= (dynamic)s;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> set) where T : struct, IComparable<T>
        {
            T min = set.FirstOrDefault();
            foreach(var s in set)
            {
                if(min.CompareTo(s) >= 0)
                {
                    min = s;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> set) where T : struct, IComparable<T>
        {
            T max = set.FirstOrDefault();
            foreach (var s in set)
            {
                if (max.CompareTo(s) <= 0)
                {
                    max = s;
                }
            }
            return max;
        }

        public static T Average<T>(this IEnumerable<T> set) where T : struct
        {
            T sum = set.Sum();
            T count = (dynamic)set.Count();
            T result = (dynamic)sum / count;
            return result;
        }

        // needed extension for task 14

        public static bool CountNumberInCollecion<T>(this IEnumerable<T> set, T num, int countRepeat) where T : struct
        {
            foreach(var i in set)
            {
                if((dynamic)i == num)
                {
                    countRepeat--;
                }
            }
            if (countRepeat == 0)
                return true;
            return false;
        }

        /*
         17. Longest string

            Write a program to return the string with maximum length from an array of strings.
            Use LINQ.

        */

        public static string ReturnLongestString<T>(this IEnumerable<string> set)
        {
            var sortSet =
                from str in set
                orderby str.Length descending
                select str;

            foreach(var p in sortSet)
            {
                return (dynamic)p;
            }
            return string.Empty;
        }
    }
}
