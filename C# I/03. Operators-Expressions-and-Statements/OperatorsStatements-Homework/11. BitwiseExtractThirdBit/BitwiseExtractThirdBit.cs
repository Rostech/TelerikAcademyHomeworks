using System;

namespace _11.BitwiseExtractThirdBit
{
    class BitwiseExtractThirdBit
    {
        /*
          Bitwise: Extract Bit #3

            Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
            The bits are counted from right to left, starting from bit #0.
            The result of the expression should be either 1 or 0.
        */

        static void Main()
        {
            uint[] n = { 5, 0, 15, 5343, 62241};
            uint mask = 1;
            for(int i = 0; i < n.Length; i++)
            {
                mask = 1 << 3;
                uint nAndMask = n[i] & mask;
                nAndMask = nAndMask >> 3;
                Console.WriteLine("n = {0}  binary representation = {1}  bit#3 = {2}",n[i], Convert.ToString(n[i],2).PadLeft(16,'0'), nAndMask);
            }
        }
    }
}
