
namespace Vernekar.AdaptorDesignPattern.Target
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the Target prototype
    /// </summary>
    public interface IConvertor
    {
        List<string> GetData();
    }
}
