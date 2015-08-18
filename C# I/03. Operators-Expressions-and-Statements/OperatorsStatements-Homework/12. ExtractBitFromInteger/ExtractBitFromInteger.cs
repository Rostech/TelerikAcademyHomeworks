using System;

namespace _12.ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        /*Extract Bit from Integer

            Write an expression that extracts from given integer n the value of given bit at index p.
        */

        static void Main()
        {
            uint[] n = { 5, 0, 15, 5343, 62241 };
            int[] p = { 2, 9, 1, 7, 11 };
            int mask = 1;
            for (int i = 0; i < n.Length; i++)
            {
                mask = 1 << p[i];
                uint nAndMask = (uint)n[i] & (uint)mask;
                nAndMask = nAndMask >> p[i];
                Console.WriteLine("n = {0}  binary representation = {1}  bit#{2} = {3}", n[i], Convert.ToString(n[i], 2).PadLeft(16, '0'),p[i], nAndMask);
            }
        }
    }
}
