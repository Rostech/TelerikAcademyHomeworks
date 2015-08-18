namespace ControlStructures.Task03RefactorTheLoop
{
    using System;

    class RefactoringLoop
    {
        public static void SearchForValue(int[] array,int expectedValue)
        {
            int i = 0;
            bool valueFound = false;
            for (i = 0; i < array.Length; i++)
            {
                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        valueFound = true;
                        break;
                    }
                }
                Console.WriteLine(array[i]);
            }
            // More code here
            if (valueFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
