using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vernekar.DecoratorDesignPattern.Component;

namespace Vernekar.DecoratorDesignPattern.ConcrateComponent
{
    public sealed class Tata : ICar
    {
        public Tata(string carName, string yearOfModel)
        {
            Name = carName;
            YearOfModel = yearOfModel;
        }

        public string Name { get; set; }

        public string YearOfModel { get; set; }

        public double GetExShowRoomPrice()
        {
            return 2000000;
        }
    }
}
