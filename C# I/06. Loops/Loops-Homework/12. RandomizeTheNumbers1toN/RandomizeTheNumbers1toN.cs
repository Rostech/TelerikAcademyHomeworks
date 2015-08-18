using System;
using System.Collections.Generic;
class RandomizeTheNumbers1toN
{
    /*
        12.* Randomize the Numbers 1…N

        Write a program that enters in integer n and prints the numbers 
        1, 2, …, n in random order.
    */

    static void Main()
    {
        Console.Write("Enter number of numbers: ");
        int n = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        List<int> selectedNumbers = new List<int>();
        selectedNumbers.Add(0);
        bool printRandom = false;
        for(int i = 1; i <= n;)
        {
            int random = randomGenerator.Next(1, n + 1);
            printRandom = true;
            for(int j = 0; j < selectedNumbers.Count; j++)
            {
                if(random == selectedNumbers[j])
                {
                    printRandom = false;
                    break;
                }
            }
            if(printRandom)
            {
                Console.WriteLine(random);
                selectedNumbers.Add(random);
                i++;
            }
        }
    }
}

