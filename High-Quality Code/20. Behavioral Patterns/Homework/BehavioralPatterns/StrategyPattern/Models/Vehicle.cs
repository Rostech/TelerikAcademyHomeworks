namespace StrategyPattern.Models
{
    using System;

    internal abstract class Vehicle
    {
        internal virtual void StartEngine()
        {
            Console.WriteLine("Engine has started.");
        }

        internal virtual void LightsOn()
        {
            Console.WriteLine("Lights are on.");
        }

        internal virtual void Drive()
        {
            Console.WriteLine("Vehile is moving.");
        }

        internal virtual void Stop()
        {
            Console.WriteLine("Vehile stopped.");
        }
    }
}
