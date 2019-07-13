
namespace Vernekar.FactoryMethod.ConcrateProduct
{
    using System;
    using Vernekar.FactoryMethod.Product;

    /// <summary>
    /// Represents the Concrete project as PC/SC Reader, which will have the actual defination of Connect, Exchance and Disconnect
    /// </summary>
    public class PcScReader : ISmartCardReader
    {
        public void Connect()
        {
            Console.WriteLine("PC/SC Reader Connected");
        }

        public void Disconnect()
        {
            Console.WriteLine("PC/SC Reader Disconnected");
        }

        public string Exchange(string input)
        {
            Console.WriteLine("PC/SC is communicating");
            Console.WriteLine($"CAPDU: {input}");
            Console.WriteLine($"RAPDU: {input}9000");
            return $"RAPDU: {input}9000";
        }
    }
}
