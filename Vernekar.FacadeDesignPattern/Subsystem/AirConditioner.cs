using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vernekar.FacadeDesignPattern.Subsystem
{
    public class AirConditioner
    {
        public void TurnOnAirConditioner()
        {
            Console.WriteLine("TURN ON AC");
        }

        public void TurnOffAirConditioner()
        {
            Console.WriteLine("TURN OFF AC");
        }
    }
}
