
namespace Vernekar.StrategyPattern
{
    using Vernekar.StrategyPattern.Strategy;

    /// <summary>
    /// Represent the context to execute the logger based on type of Concrete Strategy
    /// </summary>
    public class Context
    {
        private ILogWriter _logWriter = null;
        public Context(ILogWriter logWriter)
        {
            _logWriter = logWriter;
        }

        public void Write(string message, string logType)
        {
            _logWriter.Write(message, logType);
        }
    }
}
