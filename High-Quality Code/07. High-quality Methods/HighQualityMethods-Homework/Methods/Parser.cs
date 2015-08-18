namespace Methods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Parser
    {
        internal static string NumberAsText(int number)
        {
            string numberAsWord = string.Empty;
            switch (number)
            {
                case 0: 
                    numberAsWord = "zero";
                    break ;
                case 1: 
                    numberAsWord = "one"; 
                    break;
                case 2: 
                    numberAsWord = "two"; 
                    break;
                case 3: 
                    numberAsWord = "three"; 
                    break;
                case 4: 
                    numberAsWord = "four"; 
                    break;
                case 5:
                    numberAsWord = "five"; 
                    break;
                case 6: 
                    numberAsWord = "six"; 
                    break;
                case 7: 
                    numberAsWord = "seven"; 
                    break;
                case 8: 
                    numberAsWord = "eight"; 
                    break;
                case 9: 
                    numberAsWord = "nine"; 
                    break;
                default:
                    throw new ArgumentException("The number is not between 0 and 9.");
            }

            return numberAsWord;
        }

        internal static void FormatNumberVisualization(double number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }

            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }

            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }
    }
}
