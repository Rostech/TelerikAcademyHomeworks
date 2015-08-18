using System;

class SortingArray
{
    /*
      9. Sorting array

       Write a method that return the maximal element in a portion of 
       array of integers starting at given index.
       Using it write another method that sorts an array in ascending /
       descending order.

    */
    static void Main()
    {
        Console.WriteLine("Enter numbers separated by space: ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
        Console.WriteLine("The array sorted in descending order: "+string.Join(",",SortDescending(arr)));
    }

    static int FindBiggestElement(int[] arr, int startIndex)
    {
        int index = startIndex;
        for(int i = startIndex; i < arr.Length; i++)
        {
            if(arr[i] > arr[index])
            {
                index = i;
            }
        }
        return index;
    }

    static int[] SortDescending(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            int index = FindBiggestElement(array, i);
            if (array[i] != array[index])
            {
                array[i] = array[i] - (array[index]);
                array[index] = array[index] + array[i];
                array[i] = array[index] - array[i];
            }
        }
        return array;
    }
}

