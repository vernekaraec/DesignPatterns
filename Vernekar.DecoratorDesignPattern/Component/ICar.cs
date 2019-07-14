
namespace Vernekar.DecoratorDesignPattern.Component
{
    public interface ICar
    {
        string Name { get; set; }
        string YearOfModel { get; set; }

        double GetExShowRoomPrice();
    }
}
