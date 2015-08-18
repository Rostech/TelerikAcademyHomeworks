namespace WalkInMatrix
{
    using System;

    class WalkInMatrixStart
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();
            int n = 0;
            while (!int.TryParse(input, out n) || n < 0 || n > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            Matrix mtr = new Matrix(n);
            mtr.WalkInTheMatrix();
            Console.WriteLine(mtr.ToString());
        }
    }
}