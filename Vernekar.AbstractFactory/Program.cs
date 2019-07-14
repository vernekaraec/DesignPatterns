
namespace Vernekar.AbstractFactory
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FactoryExecutor.GetSmartCardFactory("A").GetCard("JCOPv2").GetCardName());
            Console.ReadLine();
        }
    }
}
