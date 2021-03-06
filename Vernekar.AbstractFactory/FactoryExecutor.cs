﻿
namespace Vernekar.AbstractFactory
{
    using Vernekar.AbstractFactory.ConcrateFactory;
    using Vernekar.AbstractFactory.Factory;
    using Vernekar.AbstractFactory.Product;

    /// <summary>
    /// Represents the helper class to trigger the factory class
    /// </summary>
    public sealed class FactoryExecutor
    {
        public static ISmartCardManufacture GetSmartCardFactory(string vendorName)
        {
            ISmartCardManufacture smartCard = null;
            switch (vendorName)
            {
                case "A":
                    smartCard = new VendorA();
                    break;
                case "B":
                    smartCard = new VendorB();
                    break;
            }
            return smartCard;
        }

        public static ICard GetCard(ISmartCardManufacture smartCard, string cardType)
        {
            return smartCard?.GetCard(cardType);
        }

        public static IReader GetReader(ISmartCardManufacture smartCard, string readerType)
        {
            return smartCard?.GetReader(readerType);
        }
    }
}
