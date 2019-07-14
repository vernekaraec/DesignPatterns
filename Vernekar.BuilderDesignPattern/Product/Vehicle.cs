
namespace Vernekar.BuilderDesignPattern.Product
{
    using System;
    using System.Collections.Generic;

    public class Vehicle
    {
        public string Model { get; set; }

        public string Name { get; set; }

        public string Engine { get; set; }

        public string Transmission { get; set; }

        public string Body { get; set; }

        public int Door { get; set; }

        public List<string> Accessories { get; set; }

        public Vehicle()
        {
            Accessories = new List<string>();
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Model: " + Model);

            Console.WriteLine("Name: " + Name);

            Console.WriteLine("Transmission: " + Transmission);

            Console.WriteLine("Body: " + Body);

            Console.WriteLine("Door: " + Door);

            Console.WriteLine("Accessories: " + string.Join(", ", Accessories));

        }
    }
}
