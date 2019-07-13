using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vernekar.DecoratorDesignPattern.Component;

namespace Vernekar.DecoratorDesignPattern.Decorator
{
    public abstract class OfferDecorator : ICar
    {
        private ICar _car;
        public OfferDecorator(ICar car)
        {
            _car = car;
        }

        public string Name { get { return _car.Name; } set { _car.Name = value; } }
        public string YearOfModel { get { return _car.YearOfModel; } set { _car.YearOfModel = value; } }

        public double GetExShowRoomPrice()
        {
            return _car.GetExShowRoomPrice();
        }

        public abstract double GetOfferPrice();
    }
}
