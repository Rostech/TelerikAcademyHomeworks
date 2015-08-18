using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = -1;
            for (int i = 2; i < 1002; i++)
            {
                k = -1 * k;
                Console.WriteLine(k * i);
            }
        }
    }
}
