using System;

namespace _02.GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        /* Gravitation on the Moon

            The gravitational field of the Moon is approximately 17% of that on the Earth.
            Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
    
         */
        static void Main()
        {
            double[] humanWeigth = { 86.0, 74.6, 53.7 };
            for(int i = 0; i < humanWeigth.Length; i++)
            {
                Console.WriteLine("weigth: {0}   weigth on the Moon: {1}", humanWeigth[i], ((humanWeigth[i] * 17) / 100));
            }
        }
    }
}
