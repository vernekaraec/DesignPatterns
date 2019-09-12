
namespace Vernekar.AdaptorDesignPattern
{
    using System;
    using Vernekar.AdaptorDesignPattern.Adaptor;
    using Vernekar.AdaptorDesignPattern.Target;

    /// <summary>
    /// Converts the data into one type to another type to make system compartablity 
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            IConvertor adaptor = new CardLogAdaptor("Path");
            adaptor.GetData();
            Console.WriteLine(string.Join(Environment.NewLine,adaptor.GetData()));
            Console.ReadLine();
        }
    }
}
