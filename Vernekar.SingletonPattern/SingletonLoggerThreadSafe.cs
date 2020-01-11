using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vernekar.SingletonPattern
{
    public sealed class SingletonLoggerThreadSafe
    {
        private static readonly object _objLock = new object();
        private static SingletonLoggerThreadSafe _instance = null;
        private SingletonLoggerThreadSafe()
        {

        }

        public static SingletonLoggerThreadSafe Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_objLock)
                    {
                        if (_instance == null)
                            _instance = new SingletonLoggerThreadSafe();
                    }
                }
                return _instance;
            }
        }
    }
}
