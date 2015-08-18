using System;


class FirstLargerThanNeighbours
{
    /*
      6. First larger than neighbours

        Write a method that returns the index of the first element in 
        array that is larger than its neighbours, or -1, if there’s 
        no such element.
        Use the method from the previous exercise.

    */

    static int FirstLager(int[] arr)
    {
        for(int i = 1; i < arr.Length -1; i++)
        {
            if (LargerThanNeighbours.LargerThanNeighboursMethod(arr, i))
                return i;
        }
        return -1;
    }

    static void Main()
    {
        Console.Write("Enter integers separated by space: \n");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int result = FirstLager(arr);
        if( result > 0)
        {
            Console.WriteLine("The number at index {0} is bigger than it's neighbours.", result);
        }
        else
        {
            Console.WriteLine("There isn't an element that is bigger than is's neighbours.");
        }
    }
}

