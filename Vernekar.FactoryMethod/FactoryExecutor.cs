
namespace Vernekar.FactoryMethod
{
    using Vernekar.FactoryMethod.ConcreteFactory;
    using Vernekar.FactoryMethod.Product;

    /// <summary>
    /// Helper class to execute the factory with reader type and get the product.
    /// </summary>
    public sealed class FactoryExecutor
    {
        public static ISmartCardReader GetReader(string readerType)
        {
            ISmartCardReader product = null;
            switch (readerType)
            {
                case "PCSC":
                    product = new PcScReaderFactory().GetSmartCardReader();
                    break;
                case "FCE":
                    product = new FCEReaderFactory().GetSmartCardReader();
                    break;
            }
            return product;
        }
    }
}
