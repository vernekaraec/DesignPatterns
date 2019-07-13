using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vernekar.DecoratorDesignPattern.Component
{
    public interface ICar
    {
        string Name { get; set; }
        string YearOfModel { get; set; }

        double GetExShowRoomPrice();
    }
}
