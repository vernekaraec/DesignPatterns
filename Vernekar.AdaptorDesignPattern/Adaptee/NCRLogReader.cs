
namespace Vernekar.AdaptorDesignPattern.Adaptee
{
    using System;

    /// <summary>
    /// Represents the Adaptee : Here you will add to read unknown format
    /// </summary>
    public class NCRLogReader
    {
        public string[] ReadLog(string path)
        {
            string data = "IFD:11223344ICC:884433559000IFD:99009922ICC:556699009000";
            return data.Split(new string[] { "IFD:", "ICC:" }, StringSplitOptions.None);
        }
    }
}
