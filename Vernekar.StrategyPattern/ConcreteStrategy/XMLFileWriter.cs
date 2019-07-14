

namespace Vernekar.StrategyPattern.ConcreteStrategy
{
    using System;
    using Vernekar.StrategyPattern.Strategy;

    /// <summary>
    /// Represent the Concrete Strategy prototype for XML type logger
    /// </summary>
    public class XMLFileWriter : ILogWriter
    {
        public void Write(string message, string LogType)
        {
            Console.WriteLine($"Writing message in XML file: {LogType} : {message}");
        }
    }
}
