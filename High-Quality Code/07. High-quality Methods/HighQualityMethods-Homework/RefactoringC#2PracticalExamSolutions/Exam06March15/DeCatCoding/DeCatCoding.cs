namespace DeCatCoding
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    /*
       You will receive a set on letter-numbers (strings) on one line separated with a single space ‘ ‘. 
       You have to decode every word transferring it from 21-based numeral system to 26-based numeral system 
       (the whole English alphabet).
       For example, if you have the word “cb” in decimal system that will be 2*21 + 1*1 = 43. That in 26-based 
       system is 43 % 26 = 17 = ‘r’, 1 % 26 = 1 = ‘b’. So in 21-based “cb” is “br” in 26.based system.

   */

    internal class DeCatCoding
    {
        public static void Main(string[] args)
        {
            Dictionary<char, BigInteger> system = FillKeyLatinLetterWithValueNumber(21);
            Dictionary<BigInteger, char> alphabeth = FillKeyNumberWithValueLatinLetter(26);
            string[] input = Console.ReadLine().Trim().Split();
            ulong powerNumber = 0;
            BigInteger powerResult = 0;
            List<char> strB = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                powerNumber = (ulong)input[i].Length - 1;
                for (int letter = 0; letter < input[i].Length; letter++)
                {
                    powerResult += system[input[i][letter]] * (BigInteger)Math.Pow(21, powerNumber--);
                }

                while (powerResult > 0)
                {
                    strB.Add(alphabeth[powerResult % 26]);
                    powerResult /= 26;
                }

                strB.Reverse();
                strB.Add(' ');
                Console.Write(string.Join("", strB));
                strB.Clear();
            }

            Console.WriteLine();
        }

        private static Dictionary<char, BigInteger> FillKeyLatinLetterWithValueNumber(int numberOfLetters)
        {
            if (numberOfLetters > 26)
            {
                throw new ArgumentException("There are only 26 latin letters!");
            }

            Dictionary<char, BigInteger> keyLetterValueNumber = new Dictionary<char, BigInteger>();
            for (int i = 0; i < numberOfLetters; i++)
            {
                keyLetterValueNumber.Add(((char)(97 + i)), i);
            }

            return keyLetterValueNumber;
        }

        private static Dictionary<BigInteger, char> FillKeyNumberWithValueLatinLetter(int numberOfLetters)
        {
            if (numberOfLetters > 26)
            {
                throw new ArgumentException("There are only 26 latin letters!");
            }

            Dictionary<BigInteger, char> keyNumberValueLetter = new Dictionary<BigInteger, char>();
            for (int i = 0; i < numberOfLetters; i++)
            {
                keyNumberValueLetter.Add(i, ((char)(97 + i)));
            }

            return keyNumberValueLetter;
        }
    }
}
