
namespace Vernekar.DecoratorDesignPattern.ConcrateDecorator
{
    using Vernekar.DecoratorDesignPattern.Component;

    public class StaffOffer : DiwaliOffer
    {
        public StaffOffer(ICar car) : base(car)
        {
        }

        public override double GetOfferPrice()
        {
            return base.GetOfferPrice() - (.10 * base.GetExShowRoomPrice());
        }
    }
}
