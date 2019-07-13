
namespace Vernekar.AbstractFactory.ConcrateFactory
{
    using Vernekar.AbstractFactory.ConcrateProduct;
    using Vernekar.AbstractFactory.Factory;
    using Vernekar.AbstractFactory.Product;

    /// <summary>
    /// Represents the Concrate Factory as Vendor A to manufacture the Smard Card products
    /// </summary>
    public class VendorA : ISmartCardManufacture
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
