
namespace Vernekar.BuilderDesignPattern.Builder
{
    using Vernekar.BuilderDesignPattern.Product;

    /// <summary>
    /// Interace for builder
    /// </summary>
    public interface IVehicleBuilder
    {
        /// <summary>
        /// Build Engine for Vehicle
        /// </summary>
        /// <returns>IVehicleBuilder</returns>
        IVehicleBuilder BuildEngine();

        /// <summary>
        /// Build Transmission system
        /// </summary>
        /// <returns>IVehicleBuilder</returns>
        IVehicleBuilder BuildTransmission();

        /// <summary>
        /// Build Door
        /// </summary>
        /// <returns>IVehicleBuilder</returns>
        IVehicleBuilder BuildDoor();

        /// <summary>
        /// Build Accessories
        /// </summary>
        /// <returns>IVehicleBuilder</returns>
        IVehicleBuilder BuildAccessories();

        /// <summary>
        /// Build Body
        /// </summary>
        /// <returns>IVehicleBuilder</returns>
        IVehicleBuilder BuildBody();

        /// <summary>
        /// Get product
        /// </summary>
        /// <returns>Vehicle</returns>
        Vehicle GetProduct();
    }
}
