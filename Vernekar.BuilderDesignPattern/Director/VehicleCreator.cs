
namespace Vernekar.BuilderDesignPattern.Director
{
    using Vernekar.BuilderDesignPattern.Builder;
    using Vernekar.BuilderDesignPattern.Product;

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
