
namespace Vernekar.DecoratorDesignPattern.ConcrateComponent
{
    using Vernekar.DecoratorDesignPattern.Component;

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
