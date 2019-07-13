using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vernekar.FacadeDesignPattern.Facade;

namespace Vernekar.FacadeDesignPattern
{
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
