using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CheckBitAtGivenPosition
{
    class CheckBitAtGivenPosition
    {
        /*
           Check a Bit at Given Position

            Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1
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
                //Console.WriteLine("n = {0}  binary representation of n = {1}  bit#{2} = {3}", n[i], Convert.ToString(n[i], 2).PadLeft(16, '0'), p[i], nAndMask);
                if(nAndMask == 1)
                {
                    Console.WriteLine("n = {0}  binary representation of n = {1}  bit#{2} = true", n[i], Convert.ToString(n[i], 2).PadLeft(16, '0'), p[i]);
                }
                else
                {
                    Console.WriteLine("n = {0}  binary representation of n = {1}  bit#{2} = false", n[i], Convert.ToString(n[i], 2).PadLeft(16, '0'), p[i]);
                }
            }
        }
    }
}
