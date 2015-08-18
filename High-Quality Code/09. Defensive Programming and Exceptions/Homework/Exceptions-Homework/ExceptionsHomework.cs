using System;
using System.Collections.Generic;
using System.Text;

class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if(arr.Length == 0 || arr == null)
        {
            throw new ArgumentException("The collection can't be empty or null!");
        }

        if(startIndex < 0 || startIndex > arr.Length)
        {
            throw new ArgumentException("The start index can't be less than 0 or bigger than the collections length!");
        }

        if(count < 0 || count > arr.Length)
        {
            throw new ArgumentException("The count of sub items can't be less than 0 or bigger than the collections length!");
        }

        if(count + startIndex > arr.Length)
        {
            throw new ArgumentException("The start index + count of sub items can't be less than 0 or bigger than the collections length!");
        }
        
        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if(str == null || str.Length == 0)
        {
            throw new ArgumentException("The string can't be empty!");
        }

        if(count < 0 || count > str.Length)
        {
            throw new ArgumentException("The count can't be less than 0 or bigger than the string's length!");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }
        return result.ToString();
    }

    public static void CheckPrime(int number)
    {
        if(number > 0)
        {
            throw new ArgumentException("The number can't be less than 0!");
        }

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                Console.WriteLine("The number {0} is not prime!", number);
            }
        }

        Console.WriteLine("The number {0} is prime!", number);
    }

    static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(String.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(String.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(String.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));
        Console.WriteLine(ExtractEnding("Hi", 100));

        CheckPrime(23);
        CheckPrime(33);

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };

        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
