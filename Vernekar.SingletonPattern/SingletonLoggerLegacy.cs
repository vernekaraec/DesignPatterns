using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vernekar.SingletonPattern
{
    public sealed class SingletonLoggerLegacy
    {
        private static readonly SingletonLoggerLegacy _singletonLoggerLegacy = new SingletonLoggerLegacy();
        private SingletonLoggerLegacy()
        {
    
        }

        static SingletonLoggerLegacy()
        {

        }

        public static SingletonLoggerLegacy Instance
        {
            get
            {
                return _singletonLoggerLegacy;
            }
        }
    }
}
