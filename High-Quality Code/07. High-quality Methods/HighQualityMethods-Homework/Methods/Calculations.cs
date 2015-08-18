namespace Methods
{
    using System;

    internal class Calculations
    {
        internal static double FindingTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("The sides can not be negative!");
            }

            if(a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException(String.Format("Sides {0}, {1}, {2} can not form a triangle!", a, b, c));
            }

            double semiPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
            return area;
        }

        internal static double CalculateDistanceBetweenPoints(double point1X, double point1Y, double point2X, double point2Y,
            out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = point1Y == point2Y;
            isVertical = point1X == point2X;

            double distance = Math.Sqrt(((point2X - point1X) * (point2X - point1X)) + ((point2Y - point1Y) * (point2Y - point1Y)));
            return distance;
        }

        internal static int MaxNumbersOfSet(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Missing set of numbers!");
            }

            int maxNumber = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }

            return maxNumber;
        }
    }
}
