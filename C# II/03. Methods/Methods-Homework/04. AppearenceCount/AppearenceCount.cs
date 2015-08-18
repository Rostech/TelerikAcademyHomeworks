using System;

class AppearenceCount
{
    /*
      4. Appearance count

    Write a method that counts how many times given number appears in given array.
    Write a test program to check if the method is workings correctly.

    */

    static void AppearanceCountMethod(int[] arr, int number)
    {
        int countAppearance = 0;
        foreach(int element in arr)
        {
            if(element == number)
            {
                countAppearance++;
            }
        }
        if(countAppearance > 0)
        {
            Console.WriteLine("The number {0} appears {1} {2}.", number, countAppearance, countAppearance > 1 ? "times" : "time");
        }
        else
        {
            Console.WriteLine("The number {0} is not found in : {1}", number, string.Join(", ", arr));
        }
    }

    static void Main()
    {
        Console.Write("Enter integers separated by space: \n");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.Write("Enter a number to search for: ");
        int number = int.Parse(Console.ReadLine());
        AppearanceCountMethod(arr, number);
    }
}

