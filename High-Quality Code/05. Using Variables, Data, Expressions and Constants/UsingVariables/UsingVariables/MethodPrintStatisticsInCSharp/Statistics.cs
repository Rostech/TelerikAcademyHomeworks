using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingVariables.MethodPrintStatisticsInCSharp
{
    /*
     Task 2. Method PrintStatistics in C#

        Refactor the following code to apply variable usage and naming best practices:
     */

    class Statistics
    {
        private void PrintMax(double maxElement)
        {
            Console.WriteLine("Maximal element: " + maxElement);
        }

        private void PrintMin(double minElement)
        {
            Console.WriteLine("Minimal element: " + minElement);
        }

        private void PrintAvg(double average)
        {
            Console.WriteLine("Average: " + average);
        }

        public void PrintStatistics(double[] arr, int numberOfElements)
        {
            double maxElement = arr[0];
            for (int i = 0; i < numberOfElements; i++)
            {
                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                }
            }

            PrintMax(maxElement);

            double minElement = arr[0];
            for (int i = 0; i < numberOfElements; i++)
            {
                if (arr[i] < minElement)
                {
                    minElement = arr[i];
                }
            }

            PrintMin(minElement);

            double sumOfElements = 0;
            for (int i = 0; i < numberOfElements; i++)
            {
                sumOfElements += arr[i];
            }

            double average = sumOfElements / numberOfElements;
            PrintAvg(average);
        }   
    }
}
