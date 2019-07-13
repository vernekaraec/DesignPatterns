using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vernekar.FacadeDesignPattern.Subsystem
{
    public class HomeSecurity
    {
        public void TurnOnHomeSecurity()
        {
            Console.WriteLine("TURN ON HOME SECURITY");
        }

        public void TurnOffHomeSecurity()
        {
            Console.WriteLine("TURN OFF HOME SECURITY");
        }
    }
}
