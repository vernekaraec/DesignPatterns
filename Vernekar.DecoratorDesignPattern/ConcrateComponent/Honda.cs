
namespace Vernekar.DecoratorDesignPattern.ConcrateComponent
{
    using Vernekar.DecoratorDesignPattern.Component;

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
