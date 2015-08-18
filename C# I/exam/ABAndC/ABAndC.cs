using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABAndC
{
    class ABAndC
    {
        static void Main(string[] args)
        {
            double[] arr = new double[3];
            double max = -200000000;
            double min = 200000000;
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
                if(max <= arr[i])
                {
                    max = arr[i];
                }
                if(min >= arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            double  s = (arr[0] + arr[1] + arr[2]) / 3;
            Console.WriteLine("{0:F3}",s);
        }
    }
}
