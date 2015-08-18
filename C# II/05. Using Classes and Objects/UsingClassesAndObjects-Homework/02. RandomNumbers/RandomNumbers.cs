using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomNumbers
{
    class RandomNumbers
    {
        /*
          2. Random numbers

            Write a program that generates and prints to the console 
            10 random values in the range [100, 200].

        */
        static Random random = new Random();
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int nextRandom = random.Next(100, 201);
                Console.WriteLine(nextRandom);
            }
        }
    }
}
