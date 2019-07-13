#region Copyright FIME India Pvt Ltd 2017
//
// All rights are reserved. Reproduction or transmission in whole or in 
// part, in any form or by any means, electronic, mechanical or otherwise, 
// is prohibited without the prior written consent of the copyright owner.
//
// Filename : ExecutionHistoryDBMongoHelper.cs
// Author   : FU939AVE
// Date     : 02/22/2018 2:36:02 PM
//
#endregion

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
