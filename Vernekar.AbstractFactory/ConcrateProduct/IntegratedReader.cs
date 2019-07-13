
namespace Vernekar.AbstractFactory.ConcrateProduct
{
    using Vernekar.AbstractFactory.Product;

    /// <summary>
    /// Represents the concrate product of manufacture
    /// </summary>
    public class IntegratedReader : IReader
    {
        public string GetReaderName()
        {
            return "Integrated Reader";
        }
    }
}
