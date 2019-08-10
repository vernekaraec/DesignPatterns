
namespace Vernekar.BuilderDesignPattern
{
    using System;
    using Vernekar.BuilderDesignPattern.ConcreteBuilder;
    using Vernekar.BuilderDesignPattern.Director;

    /// <summary>
    /// It is used to builds a complex object by using a step by step approach
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            VehicleCreator vehicleCreator = new VehicleCreator(new TataHexaVehicle("2019"));
            vehicleCreator.CreateVehicle();
            vehicleCreator.GetVehicle().DisplayDetails();
            Console.ReadLine();
        }
    }
}
