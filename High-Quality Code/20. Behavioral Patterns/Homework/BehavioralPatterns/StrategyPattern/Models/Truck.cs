namespace StrategyPattern.Models
{
    using System;

    internal class Truck : Vehicle
    {
        internal override void Drive()
        {
            Console.Write("Truck: ");
            base.Drive();
        }

        internal override void LightsOn()
        {
            Console.Write("Truck: ");
            base.LightsOn();
        }

        internal override void StartEngine()
        {
            Console.Write("Truck: ");
            base.StartEngine();
        }

        internal override void Stop()
        {
            Console.Write("Truck: ");
            base.Stop();
        }
    }
}
