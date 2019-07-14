
namespace Vernekar.FacadeDesignPattern.Subsystem
{
    using System;

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
