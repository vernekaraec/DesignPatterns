
namespace Vernekar.AbstractFactory.ConcrateProduct
{
    using Vernekar.AbstractFactory.Product;

    /// <summary>
    /// Represents the concrate product of manufacture
    /// </summary>
    public class JcopCardv2 : ICard
    {
        public string GetCardName()
        {
            return "JCOP Card v2.0";
        }
    }
}
