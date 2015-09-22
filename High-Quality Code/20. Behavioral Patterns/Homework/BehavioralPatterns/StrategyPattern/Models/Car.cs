namespace StrategyPattern.Models
{
    using System;

    internal class Car : Vehicle
    {
        internal override void Drive()
        {
            Console.Write("Car: ");
            base.Drive();
        }

        internal override void LightsOn()
        {
            Console.Write("Car: ");
            base.LightsOn();
        }

        internal override void StartEngine()
        {
            Console.Write("Car: ");
            base.StartEngine();
        }

        internal override void Stop()
        {
            Console.Write("Car: ");
            base.Stop();
        }
    }
}
