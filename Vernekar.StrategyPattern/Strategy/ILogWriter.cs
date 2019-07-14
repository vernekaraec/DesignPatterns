
namespace Vernekar.StrategyPattern.Strategy
{
    /// <summary>
    /// Represent the Strategy prototype for logger
    /// </summary>
    public interface ILogWriter
    {
        void Write(string message, string LogType);
    }
}
