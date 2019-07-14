using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vernekar.SingletonPattern
{
    public sealed class SingletonLogger
    {
        private static readonly Lazy<SingletonLogger> _singletonLoggerObj = new Lazy<SingletonLogger>(() => new SingletonLogger());

        private  SingletonLogger()
        {

        }

        public static SingletonLogger SingletonLoggerInstance
        {
            get
            {
                return _singletonLoggerObj.Value;
            }
        }
    }
}
