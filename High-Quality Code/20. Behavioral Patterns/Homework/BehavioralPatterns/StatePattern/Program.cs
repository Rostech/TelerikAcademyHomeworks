namespace StatePattern
{
    using System;

    using StatePattern.Models;

    /// <summary>
    /// This example models are based on Grimm tv show, so:
    /// Wesen - person who can transform 
    /// Woge - creature state
    /// Nomal - person state
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var monroe = new Person("Monroe");
            Console.WriteLine(monroe.ToString());
            Console.WriteLine(new string('-', 60));
            monroe.Transform();
            Console.WriteLine(new string('-', 60));
            Console.WriteLine(monroe.ToString());
            Console.WriteLine(new string('-', 60));
            monroe.GetExited(1);
            Console.WriteLine(new string('-', 60));
            Console.WriteLine(monroe.ToString());
            Console.WriteLine(new string('-', 60));
            monroe.GetExited(6);
            Console.WriteLine(new string('-', 60));
            Console.WriteLine(monroe.ToString());
            Console.WriteLine(new string('-', 60));
        }
    }
}
