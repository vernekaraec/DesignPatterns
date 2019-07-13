
namespace Vernekar.AdaptorDesignPattern.Adaptee
{
    using System.Collections.Generic;
    using System.Linq;
    using Vernekar.AdaptorDesignPattern.Adaptor;
    using Vernekar.AdaptorDesignPattern.Target;

    /// <summary>
    /// Represents the Adaptor: Converts into needed format
    /// </summary>
    public class CardLogAdaptor : NCRLogReader, IConvertor
    {
        private readonly string _path;
        public CardLogAdaptor(string path)
        {
            _path = path;
        }

        public List<string> GetData()
        {
           return base.ReadLog(_path).ToList();
        }
    }
}
