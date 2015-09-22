namespace StatePattern.States
{
    using System;

    using StatePattern.Models;

    internal class WogeState : State
    {
        private readonly double WogeStateHitPower = 7;
        private readonly double WogeStateRunSpeed = 6;

        internal WogeState(Person person)
            : base(person)
        {
            this.Person.HitPower = this.WogeStateHitPower;
            this.Person.RunSpeed = this.WogeStateRunSpeed;
            this.MinimalExitementLevel = 5.0;
            this.MaximalExitementLevel = 8.0;
        }

        internal override void GetExited(double exitementLevel)
        {
            if(exitementLevel < this.MinimalExitementLevel)
            {
                Console.WriteLine("Transforming because I'm not exited");
                this.Person.State = new NormalState(this.Person);
            }
        }

        internal override void Transform()
        {
            this.Person.State = new NormalState(this.Person);
        }
    }
}
