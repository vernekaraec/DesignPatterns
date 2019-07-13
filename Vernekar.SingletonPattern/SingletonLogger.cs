using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vernekar.SingletonPattern
{
    public sealed class SingletonLogger
    {
        private static readonly Lazy<SingletonLogger> singletonLoggerObj = new Lazy<SingletonLogger>(() => new SingletonLogger());

        private  SingletonLogger()
        {

        }

        public static SingletonLogger SingletonLoggerInstance
        {
            get
            {
                return singletonLoggerObj.Value;
            }
        }
    }
}
