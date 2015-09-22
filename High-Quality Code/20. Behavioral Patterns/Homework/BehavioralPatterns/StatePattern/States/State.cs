namespace StatePattern.States
{
    using System;

    using StatePattern.Models;

    internal abstract class State
    {
        protected State(Person person)
        {
            this.Person = person;
        }

        protected Person Person { get; set; }

        protected double MinimalExitementLevel { get; set; }

        protected double MaximalExitementLevel { get; set; }

        internal abstract void GetExited(double exitementLevel);

        internal virtual void Transform()
        {
            Console.WriteLine("Transforming...");
        }
    }
}
