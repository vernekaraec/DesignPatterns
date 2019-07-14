
namespace Vernekar.StrategyPattern
{
    using System;
    using Vernekar.StrategyPattern.ConcreteStrategy;


    class Program
    {
        static void Main(string[] args)
        {
            Context ctx = null;
            ctx = new Context(new MongoDBWriter());
            ctx.Write("Record added in DB", "INFO");

            ctx = new Context(new TextFileWriter());
            ctx.Write("Record logged in Text file", "INFO");

            ctx = new Context(new XMLFileWriter());
            ctx.Write("Record logged in XML", "INFO");

            Console.ReadLine();
        }
    }
}
