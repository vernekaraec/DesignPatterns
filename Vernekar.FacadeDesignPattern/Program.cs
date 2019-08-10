using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vernekar.FacadeDesignPattern.Facade;

namespace Vernekar.FacadeDesignPattern
{
    /// <summary>
    /// The higher-level interface that makes the subsystem easier to use
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            HomeFacade homeFacade = new HomeFacade();
            homeFacade.LeaveFromHome();
            Console.ReadKey();
        }
    }
}
