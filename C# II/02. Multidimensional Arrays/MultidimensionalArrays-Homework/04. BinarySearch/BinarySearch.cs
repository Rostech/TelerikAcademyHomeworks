using System;
using System.Linq;

class BinarySearch
{
    /*
      4. Binary search

        Write a program, that reads from the console an array of N 
        integers and an integer K, sorts the array and using the 
        method Array.BinSearch() finds the largest number in the 
        array which is ≤ K.

    */
    static void Main()
    {
        Console.WriteLine("Enter integer number in the array separated by space: ");
        int[] arr = Console.ReadLine().Split().Select<string, int>(n => int.Parse(n)).ToArray<int>();
        Console.Write("Enter number K: ");
        int k = int.Parse(Console.ReadLine());
        Array.Sort(arr);
        int index = 0;
        int p = 0;
        Console.WriteLine("\ninput: ");
        Console.WriteLine("[ " + string.Join(" | ",arr) + " ]");
        Console.WriteLine("\nresult: ");
        if(k >= arr[0])
        {
            while (true)
            {
                index = Array.BinarySearch(arr, k - p);
                p++;
                if (index >= 0) break;
            }
            Console.WriteLine("number {0} on index {1}", arr[index], index);
        }
        else
        {
            Console.WriteLine("There is no such number! K is < {0} = arr[{1}]", arr[index], index);
        }
        Console.WriteLine();
    }
}

