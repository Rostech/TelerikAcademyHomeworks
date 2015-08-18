using System;

class SortByStringLength
{
    /*
       5. Sort by string length

        You are given an array of strings. Write a method that sorts 
        the array by the length of its elements (the number of characters 
        composing them).

    */

    static int Partition(string[] arr, int startIndex, int endIndex)
    {
        string pivot = arr[endIndex];
        int index = startIndex;
        string change = string.Empty;
        for (int i = startIndex; i < endIndex; i++)
        {
            if(arr[i].Length <= pivot.Length )
            {
                change = arr[i];
                arr[i] = arr[index];
                arr[index] = change;
                index++;
            }
        }
        change = arr[index];
        arr[index] = arr[endIndex];
        arr[endIndex] = change;
        return index;
    }

    static void QuickSortString(string[] arr, int startIndex, int endIndex)
    {
        int index = 0;
        if(startIndex < endIndex)
        {
            index = Partition(arr, startIndex, endIndex);
            QuickSortString(arr, startIndex, index - 1);
            QuickSortString(arr, index + 1, endIndex);
        }
    }

    static void Main()
    {
        Console.Write("Enter how many strings we will have in the array: ");
        int n = int.Parse(Console.ReadLine());
        string[] arr = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter string in arr[{0}] = ", i);
            arr[i] = Console.ReadLine();
        }
        Console.WriteLine("\nYour array is:\n[ "+string.Join(", ",arr)+" ]");
        QuickSortString(arr, 0, arr.Length - 1);
        Console.WriteLine("\nYour sorted array is:\n[ " + string.Join(", ", arr) + " ]\n");
    }
}

