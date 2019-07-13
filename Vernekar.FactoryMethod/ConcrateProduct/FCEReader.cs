
namespace Vernekar.FactoryMethod.ConcrateProduct
{
    using System;
    using Vernekar.FactoryMethod.Product;

    /// <summary>
    /// Represents the Concrete project as FCE Reader, which will have the actual defination of Connect, Exchance and Disconnect
    /// </summary>
    public class FCEReader : ISmartCardReader
    {
        public void Connect()
        {
            Console.WriteLine("FCE Reader Connected");
        }

        public void Disconnect()
        {
            Console.WriteLine("FCE Reader Disconnected");
        }

        public string Exchange(string input)
        {
            Console.WriteLine("FCE is communicating");
            Console.WriteLine($"CAPDU: {input}");
            Console.WriteLine($"RAPDU: {input}9000");
            return $"RAPDU: {input}9000";
        }
    }
}
