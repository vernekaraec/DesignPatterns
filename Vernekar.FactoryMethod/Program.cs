
namespace Vernekar.FactoryMethod
{
    using System;
    using Vernekar.FactoryMethod.Product;

    public class Program
    {
        static void Main(string[] args)
        {
            ISmartCardReader reader = FactoryExecutor.GetReader("FCE");
            if(reader!= null)
            {
                reader.Connect();
                reader.Exchange("1122334455");
                reader.Disconnect();
            }
            Console.ReadLine();
        }
    }
}
