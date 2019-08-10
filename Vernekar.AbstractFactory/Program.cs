
namespace Vernekar.AbstractFactory
{
    using System;

    /// <summary>
    /// Creates an instance of several families of classes
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FactoryExecutor.GetSmartCardFactory("A").GetCard("JCOPv2").GetCardName());
            Console.ReadLine();
        }
    }
}
