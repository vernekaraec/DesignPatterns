
namespace Vernekar.FactoryMethod.ConcreteFactory
{
    using Vernekar.FactoryMethod.ConcrateProduct;
    using Vernekar.FactoryMethod.Factory;
    using Vernekar.FactoryMethod.Product;

    /// <summary>
    /// Represents the Concret Factory of PC/SC reader to create an instance of Concrete product
    /// </summary>
    public class PcScReaderFactory : SmartCardReaderFactory
    {
        public override ISmartCardReader GetSmartCardReader()
        {
            return new PcScReader();
        }
    }
}
