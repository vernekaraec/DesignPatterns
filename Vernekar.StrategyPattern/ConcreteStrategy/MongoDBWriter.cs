
namespace Vernekar.StrategyPattern.ConcreteStrategy
{
    using System;
    using Vernekar.StrategyPattern.Strategy;

    /// <summary>
    /// Represent the Concrete Strategy prototype for Mongo DB type logger
    /// </summary>
    public class MongoDBWriter : ILogWriter
    {
        public void Write(string message, string LogType)
        {
            Console.WriteLine($"Writing message in Mongo DB : {LogType} : {message}");
        }
    }
}
