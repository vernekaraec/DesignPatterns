using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vernekar.SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var u = SingletonLoggerLegacy.Instance;
            u = SingletonLoggerLegacy.Instance;
            u = SingletonLoggerLegacy.Instance;
            u = SingletonLoggerLegacy.Instance;

            var v = SingletonLogger.SingletonLoggerInstance;
            v = SingletonLogger.SingletonLoggerInstance;
            v = SingletonLogger.SingletonLoggerInstance;
            v = SingletonLogger.SingletonLoggerInstance;
        }
    }
}
