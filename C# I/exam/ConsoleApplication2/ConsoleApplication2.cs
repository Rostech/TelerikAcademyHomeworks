using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication2
{
    class ConsoleApplication2
    {
        static void Main(string[] args)
        {


            string end = Console.ReadLine();
            BigInteger num = 0;
            BigInteger productNum = 1;
            BigInteger productAll = 1;
            BigInteger tempProduct = 1;
            long count = 0;
            bool flag = true;
            while (end != "END")
            {
                //num = Convert.ToInt64(end);
                // if even
                if (count % 2 == 0)//&& count < 10)
                {
                    productNum = 1;
                    if (end == "0")
                    {
                        productAll *= 1;
                    }
                    //while (num >= 1)
                    //{
                    //    digit = (int)num % 10;
                    //    if (digit != 0)
                    //    {
                    //        productNum *= digit;
                    //    }
                    //    num /= 10;
                    //}
                    else
                    {
                        for (int i = 0; i < end.Length; i++)
                        {
                            if (end[i] != '0')
                            {
                                int n = Convert.ToInt32(end[i].ToString());
                                productNum *= n;// Convert.ToInt32(end[i].ToString());
                            }
                        }
                        productAll *= productNum;
                    }
                }
                // if input > 10
                if (count == 9 && flag)
                {
                    tempProduct = productAll;
                    productAll = 1;
                    count = -1;
                    flag = false;
                }
                end = Console.ReadLine();
                count++;
            }

            if (!flag)
            {
                Console.WriteLine(tempProduct);
                Console.WriteLine(productAll);
            }
            else
            {
                Console.WriteLine(productAll);
            }
        }
    }
}
