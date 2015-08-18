namespace Methods
{
    using System;

    internal class Methods
    {   /*
         Task 1. Quality Methods

            Take the VS solution Methods and refactor its code to follow the guidelines of high-quality methods.
            Ensure:
            you handle errors correctly
            when the methods cannot do what their name says, throw an exception (do not return wrong result).
            good cohesion and coupling
            good naming
            no side effects, etc.
        */

        public static void Main()
        {
            Console.WriteLine(Calculations.FindingTriangleArea(3, 4, 5));
            Console.WriteLine(Parser.NumberAsText(5));
            Console.WriteLine(Calculations.MaxNumbersOfSet(5, -1, 3, 2, 14, 2, 3));

            Parser.FormatNumberVisualization(1.3, "f");
            Parser.FormatNumberVisualization(0.75, "%");
            Parser.FormatNumberVisualization(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(Calculations.CalculateDistanceBetweenPoints(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";
            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";
            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
