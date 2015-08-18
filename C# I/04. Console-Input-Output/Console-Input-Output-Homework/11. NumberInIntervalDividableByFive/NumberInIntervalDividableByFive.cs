using System;

class NumberInIntervalDividableByFive
{
    static void Main()
    {
        Console.Write("start: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("finish: ");
        int finish = int.Parse(Console.ReadLine());
        int p = 0;
        string comments = "";
        for(int i = start; i <= finish; i++)
        {
            if(i % 5 == 0)
            {
                p++;
                comments += i + ", ";
            }
        }
        if (p > 0)
        {
            Console.WriteLine("p = {0}  comments: {1}", p, comments.Remove(comments.Length - 2));
        }
        else
        {
            Console.WriteLine("p = {0}, comments: {1}", p, "-");
        }
    }
}

