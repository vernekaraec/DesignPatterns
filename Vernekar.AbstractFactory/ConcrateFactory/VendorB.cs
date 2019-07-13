
namespace Vernekar.AbstractFactory.ConcrateFactory
{
    using Vernekar.AbstractFactory.ConcrateProduct;
    using Vernekar.AbstractFactory.Factory;
    using Vernekar.AbstractFactory.Product;

    /// <summary>
    /// Represents the Concrate Factory as Vendor B to manufacture the Smard Card product
    /// </summary>
    public class VendorB : ISmartCardManufacture
    {
        public ICard GetCard(string type)
        {
            ICard card = null;
            switch (type)
            {
                case "JCOP":
                    card = new JcopCard();
                    break;

                case "JCOPv2":
                    card = new JcopCardv2();
                    break;
            }
            return card;
        }

        public IReader GetReader(string type)
        {
            IReader reader = null;
            switch (type)
            {
                case "IntegratedReader":
                    reader = new IntegratedReader();
                    break;

                case "HybridReader":
                    reader = new HybridReader();
                    break;
            }
            return reader;
        }
    }
}
