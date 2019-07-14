

namespace Vernekar.StrategyPattern.ConcreteStrategy
{
    using System;
    using Vernekar.StrategyPattern.Strategy;

    /// <summary>
    /// Represent the Concrete Strategy prototype for Text file type logger
    /// </summary>
    public class TextFileWriter : ILogWriter
    {
        public void Write(string message, string LogType)
        {
            Console.WriteLine($"Writing message in Text file: {LogType} : {message}");
        }
    }
}
