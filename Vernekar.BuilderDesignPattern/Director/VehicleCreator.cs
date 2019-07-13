using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vernekar.BuilderDesignPattern.Builder;
using Vernekar.BuilderDesignPattern.Product;

namespace Vernekar.BuilderDesignPattern.Director
{
    public class VehicleCreator
    {
        private IVehicleBuilder _vehicleBuilder;
        public VehicleCreator(IVehicleBuilder vehicleBuilder)
        {
            _vehicleBuilder = vehicleBuilder;
        }

        public void CreateVehicle()
        {
            _vehicleBuilder
                .BuildEngine()
                .BuildTransmission()
                .BuildBody()
                .BuildDoor()
                .BuildAccessories();
        }

        public Vehicle GetVehicle()
        {
            return _vehicleBuilder.GetProduct();
        }
    }
}
