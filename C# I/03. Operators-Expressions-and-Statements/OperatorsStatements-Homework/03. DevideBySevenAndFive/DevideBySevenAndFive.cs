using System;

namespace _03.DevideBySevenAndFive
{
    class DevideBySevenAndFive
    {
        /* Divide by 7 and 5

        Write a Boolean expression that checks for given integer if it 
        can be divided (without remainder) by 7 and 5 at the same time.

        */
        static void Main()
        {
            int[] n = { 3, 0, 5, 7, 35, 140 };
            for(int i =0; i < n.Length; i++)
            {
                if(n[i] % 7 == 0 && n[i] % 5 == 0 && n[i] != 0)
                {
                    Console.WriteLine(n[i] + " is devided by 7 and 5 without remainder.");
                }
                else
                {
                    Console.WriteLine(n[i] + " is not devided by 7 and 5 without remainder.");
                }
            }
        }
    }
}
