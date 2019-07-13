
namespace Vernekar.FactoryMethod.Factory
{
    using Vernekar.FactoryMethod.Product;

    /// <summary>
    /// Represents the Factory of reader to define the abstraction 
    /// </summary>
    public abstract class SmartCardReaderFactory
    {
        public abstract ISmartCardReader GetSmartCardReader();
    }
}
