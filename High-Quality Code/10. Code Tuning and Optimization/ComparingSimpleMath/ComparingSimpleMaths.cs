namespace ComparingSimpleMath
{
    using System;
    using System.Diagnostics;

    class ComparingSimpleMath
    {
        /*
         Task 2. Compare simple Maths

            Write a program to compare the performance of:
            add, subtract, increment, multiply, divide
            for the values:
            int, long, float, double and decimal
        */

        static void Main()
        {
            Stopwatch timing = new Stopwatch();

            // adding
            Console.WriteLine("Adding:");
            // int
            int sumInt = 0;
            timing.Start();
            while(sumInt <= 10000000)
            {
                sumInt += 1;
            }

            timing.Stop();
            Console.WriteLine("int: {0,20}",timing.Elapsed);
            timing.Reset();
            // long
            long sumLong = 0L;
            timing.Start();
            while (sumLong <= 10000000)
            {
                sumLong += 1;
            }

            timing.Stop();
            Console.WriteLine("long: {0,19}", timing.Elapsed);
            timing.Reset();
            // float
            float sumFloat = 0F;
            timing.Start();
            while (sumFloat <= 10000000)
            {
                sumFloat += 1;
            }

            timing.Stop();
            Console.WriteLine("float: {0,18}", timing.Elapsed);
            timing.Reset();
            // double
            double sumDouble = 0D;
            timing.Start();
            while (sumDouble <= 10000000)
            {
                sumDouble += 1;
            }

            timing.Stop();
            Console.WriteLine("double: {0,17}", timing.Elapsed);
            timing.Reset();
            // decimal
            decimal sumDecimal = 0M;
            timing.Start();
            while (sumDecimal <= 10000000)
            {
                sumDecimal += 1;
            }

            timing.Stop();
            Console.WriteLine("decimal: {0,16}", timing.Elapsed);
            timing.Reset();

            //subtract
            Console.WriteLine("\nSubstraction:");
            // int
            int substractInt = 10000000;
            timing.Start();
            while (substractInt >= 0)
            {
                substractInt -= 1;
            }

            timing.Stop();
            Console.WriteLine("int: {0,20}", timing.Elapsed);
            timing.Reset();
            // long
            long substractLong = 10000000L;
            timing.Start();
            while (substractLong >= 0)
            {
                substractLong -= 1;
            }

            timing.Stop();
            Console.WriteLine("long: {0,19}", timing.Elapsed);
            timing.Reset();
            // float
            float substractFloat = 10000000F;
            timing.Start();
            while (substractFloat >= 0)
            {
                substractFloat -= 1;
            }

            timing.Stop();
            Console.WriteLine("float: {0,18}", timing.Elapsed);
            timing.Reset();
            // double
            double substractDouble = 10000000D;
            timing.Start();
            while (substractDouble >= 0)
            {
                substractDouble -= 1;
            }

            timing.Stop();
            Console.WriteLine("double: {0,17}", timing.Elapsed);
            timing.Reset();
            // decimal
            decimal substractDecimal = 10000000M;
            timing.Start();
            while (substractDecimal >= 0)
            {
                substractDecimal -= 1;
            }

            timing.Stop();
            Console.WriteLine("decimal: {0,16}", timing.Elapsed);
            timing.Reset();

            // Incrementing
            Console.WriteLine("\nIncrementing:");
            // int
            int incrementInt = 0;
            timing.Start();
            while (incrementInt <= 10000000)
            {
                incrementInt++;
            }

            timing.Stop();
            Console.WriteLine("int: {0,20}", timing.Elapsed);
            timing.Reset();
            // long
            long incrementLong = 0L;
            timing.Start();
            while (incrementLong <= 10000000)
            {
                incrementLong++;
            }

            timing.Stop();
            Console.WriteLine("long: {0,19}", timing.Elapsed);
            timing.Reset();
            // float
            float incrementingFloat = 0F;
            timing.Start();
            while (incrementingFloat <= 10000000)
            {
                incrementingFloat++;
            }

            timing.Stop();
            Console.WriteLine("float: {0,18}", timing.Elapsed);
            timing.Reset();
            // double
            double incrementingDouble = 0D;
            timing.Start();
            while (incrementingDouble <= 10000000)
            {
                incrementingDouble++;
            }

            timing.Stop();
            Console.WriteLine("double: {0,17}", timing.Elapsed);
            timing.Reset();
            // decimal
            decimal incrementingDecimal = 0M;
            timing.Start();
            while (incrementingDecimal <= 10000000)
            {
                incrementingDecimal++;
            }

            timing.Stop();
            Console.WriteLine("decimal: {0,16}", timing.Elapsed);
            timing.Reset();

            // Multiplying
            Console.WriteLine("\nMultiplying: ");
            // int
            int multiplyInt = 1;
            timing.Start();
            while (multiplyInt <= 100000000)
            {
                multiplyInt *= 2;
            }

            timing.Stop();
            Console.WriteLine("int: {0,20}", timing.Elapsed);
            timing.Reset();
            // long
            long multiplyLong = 1L;
            timing.Start();
            while (multiplyLong <= 100000000)
            {
                multiplyLong *= 2;
            }

            timing.Stop();
            Console.WriteLine("long: {0,19}", timing.Elapsed);
            timing.Reset();
            // float
            float multiplyFloat = 1F;
            timing.Start();
            while (multiplyFloat <= 100000000)
            {
                multiplyFloat *= 2;
            }

            timing.Stop();
            Console.WriteLine("float: {0,18}", timing.Elapsed);
            timing.Reset();
            // double
            double multiplyDouble = 1D;
            timing.Start();
            while (multiplyDouble <= 100000000)
            {
                multiplyDouble *= 2;
            }

            timing.Stop();
            Console.WriteLine("double: {0,17}", timing.Elapsed);
            timing.Reset();
            // decimal
            decimal multiplyDecimal = 1M;
            timing.Start();
            while (multiplyDecimal <= 100000000)
            {
                multiplyDecimal *= 2;
            }

            timing.Stop();
            Console.WriteLine("decimal: {0,16}", timing.Elapsed);
            timing.Reset();

            // Dividing
            Console.WriteLine("\nDividing:");
            // int
            int divideInt = 10000000;
            timing.Start();
            while (divideInt >= 1)
            {
                divideInt /= 2;
            }

            timing.Stop();
            Console.WriteLine("int: {0,20}", timing.Elapsed);
            timing.Reset();
            // long
            long divideLong = 10000000L;
            timing.Start();
            while (divideLong >= 1)
            {
                divideLong /= 2;
            }

            timing.Stop();
            Console.WriteLine("long: {0,19}", timing.Elapsed);
            timing.Reset();
            // float
            float divideFloat = 10000000F;
            timing.Start();
            while (divideFloat >= 1)
            {
                divideFloat /= 2;
            }

            timing.Stop();
            Console.WriteLine("float: {0,18}", timing.Elapsed);
            timing.Reset();
            // double
            double divideDouble = 10000000D;
            timing.Start();
            while (divideDouble >= 1)
            {
                divideDouble /= 2;
            }

            timing.Stop();
            Console.WriteLine("double: {0,17}", timing.Elapsed);
            timing.Reset();
            // decimal
            decimal divideDecimal = 10000000M;
            timing.Start();
            while (divideDecimal >= 1)
            {
                divideDecimal /= 2;
            }

            timing.Stop();
            Console.WriteLine("decimal: {0,16}", timing.Elapsed);
            timing.Reset();
        }
    }
}
