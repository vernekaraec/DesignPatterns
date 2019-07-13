using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vernekar.BuilderDesignPattern.Builder;
using Vernekar.BuilderDesignPattern.Product;

namespace Vernekar.BuilderDesignPattern.ConcreteBuilder
{
    public sealed class TataHexaVehicle : IVehicleBuilder
    {
        private Vehicle _Vehicle = null;

        public TataHexaVehicle(string model)
        {
            _Vehicle = new Vehicle();
            _Vehicle.Name = "Hexa";
            _Vehicle.Model = model;
        }
        public IVehicleBuilder BuildAccessories()
        {
            _Vehicle.Accessories.Add("Seat Cover");
            _Vehicle.Accessories.Add("Rear Mirror");
            _Vehicle.Accessories.Add("Foot light");
            _Vehicle.Accessories.Add("Rear Camera");
            return this;
        }

        public IVehicleBuilder BuildBody()
        {
            _Vehicle.Body = "Jet Alloy";
            return this;
        }

        public IVehicleBuilder BuildDoor()
        {
            _Vehicle.Door = 5;
            return this;
        }

        public IVehicleBuilder BuildEngine()
        {
            _Vehicle.Engine = "2.0L";
            return this;
        }

        public IVehicleBuilder BuildTransmission()
        {
            _Vehicle.Transmission = "4D";
            return this;
        }

        public Vehicle GetProduct()
        {
            return _Vehicle;
        }
    }
}
