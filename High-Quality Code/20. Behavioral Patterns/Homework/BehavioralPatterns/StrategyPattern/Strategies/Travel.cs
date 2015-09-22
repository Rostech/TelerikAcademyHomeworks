namespace StrategyPattern.Strategies
{
    using StrategyPattern.Models;

    internal class Travel
    {
        private readonly Vehicle vehicle;

        internal Travel(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        internal void PerformTrip()
        {
            vehicle.StartEngine();
            vehicle.LightsOn();
            vehicle.Drive();
            vehicle.Stop();
        }
    }
}
