using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vernekar.FacadeDesignPattern.Subsystem
{
    public class Lights
    {
        public void TurnOnLights()
        {
            Console.WriteLine("TURN ON LIGHTS");
        }

        public void TurnOffLights()
        {
            Console.WriteLine("TURN OFF LIGHTS");
        }
    }
}
