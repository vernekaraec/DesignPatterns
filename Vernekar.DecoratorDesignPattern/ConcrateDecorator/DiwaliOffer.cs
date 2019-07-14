
namespace Vernekar.DecoratorDesignPattern.ConcrateDecorator
{
    using Vernekar.DecoratorDesignPattern.Component;
    using Vernekar.DecoratorDesignPattern.Decorator;


    public class DiwaliOffer : OfferDecorator
    {
        public DiwaliOffer(ICar car) : base(car)
        {
        }

        public override double GetOfferPrice()
        {
            return base.GetExShowRoomPrice() - (.30 * base.GetExShowRoomPrice());
        }
    }
}
