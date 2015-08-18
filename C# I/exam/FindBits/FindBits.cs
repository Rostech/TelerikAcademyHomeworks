using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindBits
{
    class FindBits
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string sToBits = Convert.ToString(s, 2).PadLeft(5, '0');
            //Console.WriteLine(sToBits);
            string numberToBit = "";
            int number = 0;
            int count = 0;
            bool flag = false;
            while(n > 0)
            {
                number = int.Parse(Console.ReadLine());
                numberToBit = Convert.ToString(number, 2).PadLeft(29, '0');
                //Console.WriteLine(numberToBit);
                for (int i = 0; i <= numberToBit.Length - sToBits.Length; i++)
                {
                    flag = false;
                    for(int j = 0; j < sToBits.Length; j++)
                    {
                        if(sToBits[j] == numberToBit[i+j])
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                    if(flag)
                    {
                        count++;
                    }

                }
                n--;
            }
            Console.WriteLine(count);
        }
    }
}
