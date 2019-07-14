
namespace Vernekar.DecoratorDesignPattern.ConcrateDecorator
{
    using Vernekar.DecoratorDesignPattern.Component;
    using Vernekar.DecoratorDesignPattern.Decorator;

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
