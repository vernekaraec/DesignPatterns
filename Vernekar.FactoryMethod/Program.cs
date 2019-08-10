
namespace Vernekar.FactoryMethod
{
    using System;
    using Vernekar.FactoryMethod.Product;

    /// <summary>
    /// Factory Method lets a class defer instantiation to subclasses. 
    /// </summary>
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
