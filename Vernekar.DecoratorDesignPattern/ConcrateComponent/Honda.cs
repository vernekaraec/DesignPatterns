using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vernekar.DecoratorDesignPattern.Component;

namespace Vernekar.DecoratorDesignPattern.ConcrateComponent
{
    public sealed class Honda : ICar
    {
        public Honda(string carName, string yearOfModel)
        {
            Name = carName;
            YearOfModel = yearOfModel;
        }

        public string Name { get; set; }

        public string YearOfModel { get; set; }

        public double GetExShowRoomPrice()
        {
            return 1000000;
        }
    }
}
