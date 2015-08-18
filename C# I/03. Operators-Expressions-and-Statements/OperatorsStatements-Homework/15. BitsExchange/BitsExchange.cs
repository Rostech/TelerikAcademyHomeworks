using System;

namespace _15.BitsExchange
{
    class BitsExchange
    {
        /*
          Bits Exchange

             Write a program that exchanges bits 3, 4 and 5 with bits 
             24, 25 and 26 of given 32-bit unsigned integer.

        */
        static void Main()
        {
            uint[] number = { 1140867093, 255406592, 4294901775, 5351, 2369124121 };
            byte[] change1 = { 3, 4, 5 };
            byte[] change2 = { 24, 25, 26 };
            uint mask1 = 1;
            uint mask2 = 1;
            for(int i = 0; i < number.Length; i++)
            {
                Console.WriteLine("n = " + number[i] );
                for(int j = 0; j < change1.Length; j++)
                {
                    mask1 = (uint)(1 << change1[j]);
                    uint nAndMask1 = number[i] & mask1;
                    nAndMask1 = nAndMask1 >> change1[j];
                    mask2 = (uint)(1 << change2[j]);
                    uint nAndMask2 = number[i] & mask2;
                    nAndMask2 = nAndMask2 >> change2[j];
                    if(nAndMask1 != nAndMask2)
                    {
                        int change = 1 << change1[j];
                        number[i] = (uint)(number[i] ^ change);
                        change = 1 << change2[j];
                        number[i] = (uint)(number[i] ^ change);
                    }
                }
                Console.WriteLine("binary result = {0} result = {1}", Convert.ToString(number[i],2).PadLeft(32,'0'), number[i]);
                Console.WriteLine();
            }
        }
    }
}
