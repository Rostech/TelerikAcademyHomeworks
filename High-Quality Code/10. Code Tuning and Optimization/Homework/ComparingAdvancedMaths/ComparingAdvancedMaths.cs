namespace ComparingAdvancedMaths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ComparingAdvancedMaths
    {
        /*
         Task 3. Compare advanced Maths

            Write a program to compare the performance of:
            square root, natural logarithm, sinus
            for the values:
            float, double and decimal
        */

        static void Main(string[] args)
        {
            Stopwatch timing = new Stopwatch();

            // Square root
            Console.WriteLine("Square root: ");
            // float
            float squareRootFloat = 1000000000F;
            timing.Start();
            while(squareRootFloat > 1)
            {
                squareRootFloat = (float)Math.Sqrt(squareRootFloat);
            }

            timing.Stop();
            Console.WriteLine("float: {0,18}", timing.Elapsed);
            timing.Reset();
            // double
            double squareRootDouble = 1000000000D;
            timing.Start();
            while (squareRootDouble > 1)
            {
                squareRootDouble = Math.Sqrt(squareRootDouble);
            }

            timing.Stop();
            Console.WriteLine("double: {0,17}", timing.Elapsed);
            timing.Reset();
            // decimal
            decimal squareRootDecimal = 1000000000M;
            timing.Start();
            while (squareRootDecimal > 1)
            {
                squareRootDecimal = (decimal)Math.Sqrt((double)squareRootDecimal);
            }

            timing.Stop();
            Console.WriteLine("decimal: {0,16}", timing.Elapsed);
            timing.Reset();

            // natural logarithm
            Console.WriteLine("\nNatural logarithm");
            // float
            float naturalLogarithmFloat = 1000000000F;
            timing.Start();
            while (naturalLogarithmFloat > 1)
            {
                naturalLogarithmFloat = (float)Math.Log(naturalLogarithmFloat);
            }

            timing.Stop();
            Console.WriteLine("float: {0,18}", timing.Elapsed);
            timing.Reset();
            // double
            double naturalLogarithmDouble = 1000000000D;
            timing.Start();
            while (naturalLogarithmDouble > 1)
            {
                naturalLogarithmDouble = Math.Log(naturalLogarithmDouble);
            }

            timing.Stop();
            Console.WriteLine("double: {0,17}", timing.Elapsed);
            timing.Reset();
            // decimal
            decimal naturalLogarithmDecimal = 1000000000M;
            timing.Start();
            while (naturalLogarithmDecimal > 1)
            {
                naturalLogarithmDecimal = (decimal)Math.Log((double)naturalLogarithmDecimal);
            }

            timing.Stop();
            Console.WriteLine("decimal: {0,16}", timing.Elapsed);
            timing.Reset();
            // Sinus
            Console.WriteLine("\nSinus:");
            // float
            float sinusFloat = 0F;
            timing.Start();
            for(int i = 0; i < 1000000; i++)
            {
                sinusFloat = (float)Math.Sin(sinusFloat);
            }

            timing.Stop();
            Console.WriteLine("float: {0,18}", timing.Elapsed);
            timing.Reset();
            // double
            double sinusDouble = 0D;
            timing.Start();
            for (int i = 0; i < 1000000; i++)
            {
                sinusDouble = Math.Sin(sinusDouble);
            }

            timing.Stop();
            Console.WriteLine("double: {0,18}", timing.Elapsed);
            timing.Reset();
            // decimal
            decimal sinusDecimal = 0M;
            timing.Start();
            for (int i = 0; i < 1000000; i++)
            {
                sinusDecimal = (decimal)Math.Sin((double)sinusDecimal);
            }

            timing.Stop();
            Console.WriteLine("decimal: {0,18}", timing.Elapsed);
            timing.Reset();
        }
    }
}
