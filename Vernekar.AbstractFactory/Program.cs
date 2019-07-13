using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vernekar.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FactoryExecutor.GetSmartCardFactory("A").GetCard("JCOPv2").GetCardName());
            Console.ReadLine();
        }
    }
}
