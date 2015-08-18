namespace UsingVariables
{
    using System;

    using UsingVariables.ClassSizeInCSharp;
    using UsingVariables.MethodPrintStatisticsInCSharp;

    class UsingVariablesTest
    {
        static void Main(string[] args)
        {
            // Testing 01. Class Size in C#
            Console.WriteLine("Testing Task 1: Class Size in C#");

            double testWidth = 5.14;
            double testHeight = 3.14;

            Size testSize = new Size(testWidth, testHeight);
            Console.WriteLine("testSize.Width : " + testSize.Width);
            Console.WriteLine("testSize.Height : " + testSize.Height);

            Console.WriteLine("Size.GetRotatedSize.Width: " + Size.GetRotatedSize(testSize, testWidth).Width);
            Console.WriteLine("Size.GetRotatedSize.Height: " + Size.GetRotatedSize(testSize, testWidth).Height);

            // Testing 02. Method Print Statistics in C#
            Console.WriteLine("\nTesting Task 2: Method Print Statistics in C#");

            Statistics testStatistics = new Statistics();
            double[] statisticElements = new double[] {1, 2, 3.14, 9.231, 101};
            testStatistics.PrintStatistics(statisticElements, statisticElements.Length);
        }
    }
}
