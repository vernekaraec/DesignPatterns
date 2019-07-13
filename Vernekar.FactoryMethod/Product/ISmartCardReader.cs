
namespace Vernekar.FactoryMethod.Product
{
    /// <summary>
    /// Represents the Product as ISmartCardReader. Have actions like Connect, Exchange and Disconnect
    /// </summary>
    public interface ISmartCardReader
    {
        void Connect();

        string Exchange(string input);

        void Disconnect();
    }
}
