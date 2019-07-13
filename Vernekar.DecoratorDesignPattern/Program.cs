﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vernekar.DecoratorDesignPattern.Component;
using Vernekar.DecoratorDesignPattern.ConcrateComponent;
using Vernekar.DecoratorDesignPattern.ConcrateDecorator;
using Vernekar.DecoratorDesignPattern.Decorator;

namespace Vernekar.DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Tata("Hexa", "2019");

            OfferDecorator offerDecorator = new DiwaliOffer(car);
            Console.WriteLine("Exshowroom price : " + offerDecorator.GetExShowRoomPrice());

            Console.WriteLine("Exshowroom price after Diwali offer: " + offerDecorator.GetOfferPrice());

            offerDecorator = new StaffOffer(offerDecorator);
            Console.WriteLine("Exshowroom price after Staff offer: " + offerDecorator.GetOfferPrice());

            Console.ReadLine();
        }
    }
}
