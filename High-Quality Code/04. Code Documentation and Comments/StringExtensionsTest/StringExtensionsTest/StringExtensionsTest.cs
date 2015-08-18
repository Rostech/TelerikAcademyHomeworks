using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Telerik.ILS.Common;

namespace StringExtensionsTest
{
    class StringExtensionsTest
    {
        public static void Main()
        {
            string testString = "This is a test string for showing how StringExtensions class works.";
            Console.WriteLine(testString);
            Console.WriteLine("1. ToMd5Hash(testString) -> " + StringExtensions.ToMd5Hash(testString));
            string s = "pishka";
            DateTime n;
            DateTime.TryParse(s, out n);
            Console.WriteLine(n);
            Console.WriteLine(StringExtensions.ConvertLatinToCyrillicKeyboard("a"));
        }
    }
}
