using System;

namespace _16.BitExchangeAdvance
{
    class BitExchangeAdvance
    {
        /*
          Bit Exchange (Advanced)

            Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
            The first and the second sequence of bits may not overlap.

        */
        static void Main()
        {
            long[] number = { 1140867093, 4294901775, 2369124121, 987654321, 123456789, 33333333333 };
            sbyte[] p = { 3, 24, 2, 2, 26, -1 };
            sbyte[] q = { 24, 3, 22, 8, 0, 0 };
            sbyte[] k = { 3, 3, 10, 11, 7, 33 };
            uint mask1 = 1;
            uint mask2 = 1;
            for(int i = 0; i < number.Length; i++)
            {
                Console.WriteLine("n = {0} p = {1} q = {2} k = {3}",number[i], p[i],q[i],k[i]);
                k[i]--;
                if(p[i] > q[i])
                {
                    sbyte exchange = p[i];
                    p[i] = q[i];
                    q[i] = exchange;
                }
                if(p[i] < 0 || q[i] > 32 ||  q[i] + k[i]+1 > 32)
                {
                    Console.WriteLine("binary result = {0} result = out of range",Convert.ToString("").PadLeft(32,'-'));
                    Console.WriteLine();
                }
                else if (p[i] + k[i] >= q[i])
                {
                    Console.WriteLine("binary result = {0} result = overlaping", Convert.ToString("").PadLeft(32, '-'));
                    Console.WriteLine();
                }
                else
                {
                    while (k[i] > 0)
                    {
                        mask1 = (uint)(1 << p[i] + k[i]);
                        long nAndMask1 = number[i] & mask1;
                        nAndMask1 = nAndMask1 >> p[i] + k[i];
                        mask2 = (uint)(1 << q[i] + k[i]);
                        long nAndMask2 = number[i] & mask2;
                        nAndMask2 = nAndMask2 >> q[i] + k[i];
                        if (nAndMask1 != nAndMask2)
                        {
                            int change = 1 << p[i] + k[i];
                            number[i] = (uint)(number[i] ^ change);
                            change = 1 << q[i] + k[i];
                            number[i] = (uint)(number[i] ^ change);
                        }
                        k[i]--;
                    }
                    Console.WriteLine("binary result = {0} result = {1} ", Convert.ToString(number[i],2).PadLeft(32,'0'),number[i]);
                    Console.WriteLine();
                }
            }
        }
    }
}
