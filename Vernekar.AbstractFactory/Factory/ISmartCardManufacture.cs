
namespace Vernekar.AbstractFactory.Factory
{
    using Vernekar.AbstractFactory.Product;

    /// <summary>
    /// Represents the Factory to manufacture the Smard Card products
    /// </summary>
    public interface ISmartCardManufacture
    {
        ICard GetCard(string type);

        IReader GetReader(string type);
    }
}
