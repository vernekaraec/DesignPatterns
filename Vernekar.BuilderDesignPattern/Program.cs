using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vernekar.BuilderDesignPattern.ConcreteBuilder;
using Vernekar.BuilderDesignPattern.Director;

namespace Vernekar.BuilderDesignPattern
{
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
