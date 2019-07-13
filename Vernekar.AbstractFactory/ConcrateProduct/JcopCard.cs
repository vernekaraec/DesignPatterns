
namespace Vernekar.AbstractFactory.ConcrateProduct
{
    using Vernekar.AbstractFactory.Product;

    /// <summary>
    /// Represents the concrate product of manufacture
    /// </summary>
    public class JcopCard : ICard
    {
        public string GetCardName()
        {
            return "JCOP Card v1.0";
        }
    }
}
