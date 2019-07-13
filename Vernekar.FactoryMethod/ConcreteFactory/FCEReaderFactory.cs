
namespace Vernekar.FactoryMethod.ConcreteFactory
{
    using Vernekar.FactoryMethod.ConcrateProduct;
    using Vernekar.FactoryMethod.Factory;
    using Vernekar.FactoryMethod.Product;

    /// <summary>
    /// Represents the Concret Factory of FCE reader to create an instance of Concrete product
    /// </summary>
    public class FCEReaderFactory : SmartCardReaderFactory
    {
        public override ISmartCardReader GetSmartCardReader()
        {
            return new FCEReader();
        }
    }
}
