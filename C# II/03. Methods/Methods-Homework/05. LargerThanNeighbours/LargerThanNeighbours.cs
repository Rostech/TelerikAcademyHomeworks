using System;

public class LargerThanNeighbours
{
    /*
      5. Larger than neighbours

        Write a method that checks if the element at given position 
        in given array of integers is larger than its two neighbours 
        (when such exist).

    */

    public static bool LargerThanNeighboursMethod(int[] arr, int position)
    {
        if((position > 0 && position < arr.Length -1) && (arr[position-1] < arr[position])
            && (arr[position] > arr[position + 1]))
            return true;
        return false;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter integers separated by space: \n");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.Write("Enter a position: ");
        int position = int.Parse(Console.ReadLine());
        if (position > 0 && position < arr.Length)
        {
            Console.Write("The element {0} on position {1} is ", arr[position],
                position);
            if(LargerThanNeighboursMethod(arr, position))
            {
                Console.WriteLine("larger than it's neighbours.");
            }
            else
            {
                Console.WriteLine(" NOT larger than it's neighbours.");
            }
        }
        else
        {
            Console.WriteLine("The index is out range!");
        }
    }
}

