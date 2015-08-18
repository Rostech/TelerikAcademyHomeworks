using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymboltoNumber
{
    class SymboltoNumber
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            //List<double> result = new List<double>();
            double result = 0;
            //int charToNumb = 0;

            for (int i = 0; i < text.Length; i++)
            {
                // if char @
                if(text[i] == '@')
                {
                    break;
                }
                // if char is letter   are they english ot not only english
                else if((text[i] >= 'A' && text[i] <= 'Z') 
                    || (text[i] >= 'a' && text[i] <= 'z'))
                {
                    //charToNumb = text[i];
                    //Console.WriteLine(charToNumb);
                    result = ((int)text[i] * n) + 1000;
                }
                //if it is a digit
                else if(text[i] >= '0' && text[i] <= '9')
                {
                    //charToNumb = text[i];
                    result = (int)text[i] + n + 500;
                }
                // else if it is not aniithing
                else
                {
                   // charToNumb = text[i];
                    result = (int)text[i] - n;
                }


                if(i % 2 == 0 && i != 0)
                {
                    result /= 100;
                    Console.WriteLine("{0:F2}", result);
                }
                else if(i % 2 != 0 && i!=0)
                {
                    result *= 100;
                    Console.WriteLine(result);
                }
                else
                {
                    result /= 100;
                    Console.WriteLine("{0:F2}", result);
                }
            }
        }
    }
}
