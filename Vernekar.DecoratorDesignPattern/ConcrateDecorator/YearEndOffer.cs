using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vernekar.DecoratorDesignPattern.Component;
using Vernekar.DecoratorDesignPattern.Decorator;

namespace Vernekar.DecoratorDesignPattern.ConcrateDecorator
{
    public class YearEndOffer : OfferDecorator
    {
        public YearEndOffer(ICar car) : base(car)
        {
        }

        public override double GetOfferPrice()
        {
            return base.GetExShowRoomPrice() - (.20 * base.GetExShowRoomPrice());
        }
    }
}
