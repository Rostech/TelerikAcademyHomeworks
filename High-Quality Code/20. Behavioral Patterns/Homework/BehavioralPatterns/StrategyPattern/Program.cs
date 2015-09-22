namespace StrategyPattern
{
    using System;

    using StrategyPattern.Models;
    using StrategyPattern.Strategies;

    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var truck = new Truck();

            var travelByCar = new Travel(car);
            var travelByTruck = new Travel(truck);

            travelByCar.PerformTrip();
            Console.WriteLine(new string('-', 60));
            travelByTruck.PerformTrip();
        }
    }
}
