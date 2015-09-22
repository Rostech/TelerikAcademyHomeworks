namespace StatePattern.States
{
    using System;

    using StatePattern.Models;

    internal class NormalState : State
    {
        private readonly double NormalStateHitPower = 3;
        private readonly double NormalStateRunSpeed = 2;

        internal NormalState(Person person)
            : base(person)
        {
            this.Person.HitPower = this.NormalStateHitPower;
            this.Person.RunSpeed = this.NormalStateRunSpeed;
            this.MinimalExitementLevel = 0.0;
            this.MaximalExitementLevel = 4.0;
        }

        internal override void GetExited(double exitementLevel)
        {
            if(this.MaximalExitementLevel < exitementLevel)
            {
                Console.WriteLine("Transforming because I'm exited");
                this.Person.State = new WogeState(this.Person);
            }
        }

        internal override void Transform()
        {
            base.Transform();
            this.Person.State = new WogeState(this.Person);
        }
    }
}
