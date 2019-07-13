using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vernekar.FacadeDesignPattern.Subsystem
{
    public class MusicSystem
    {
        public void TurnOnMusicSystem()
        {
            Console.WriteLine("TURN ON MUSIC");
        }

        public void TurnOffMusicSystem()
        {
            Console.WriteLine("TURN OFF MUSIC");
        }
    }
}
