
namespace Vernekar.AdaptorDesignPattern
{
    using System;
    using Vernekar.AdaptorDesignPattern.Adaptee;

    public class Program
    {
        static void Main(string[] args)
        {
            CardLogAdaptor adaptor = new CardLogAdaptor("Path");
            adaptor.GetData();
            Console.WriteLine(string.Join(Environment.NewLine,adaptor.GetData()));
            Console.ReadLine();
        }
    }
}
