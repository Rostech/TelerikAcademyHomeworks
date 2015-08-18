using System;

namespace _14.ModifyBitAtPosition
{
    class ModifyBitAtPosition
    {
        /*
         Modify a Bit at Given Position

            We are given an integer number n, a bit value v (v=0 or 1) and a position p.
            Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

         */
        static void Main()
        {
            uint[] number = { 5, 0, 15, 5343, 62241 };
            uint[] position = { 2, 9, 1, 7, 11 };
            byte[] value = { 0, 1, 1, 0, 0 };
            int mask = 1;
            for(int i = 0; i < number.Length; i++)
            {
                mask = 1 << (int)position[i];
                uint nAndMask = (uint)number[i] & (uint)mask;
                nAndMask = nAndMask >> (int)position[i];
                if (nAndMask == value[i])
                {
                    Console.WriteLine("n = {0} p = {1} v = {2} binary result = {3} result = {4}", number[i],
                        position[i], value[i], Convert.ToString(number[i], 2).PadLeft(16, '0'), number[i]);
                }
                else
                {
                    int result = (int)number[i] ^ mask;
                    Console.WriteLine("n = {0} p = {1} v = {2} binary result = {3} result = {4}", number[i],
                        position[i], value[i], Convert.ToString(result, 2).PadLeft(16, '0'), result);
                }
            }
        }
    }
}
