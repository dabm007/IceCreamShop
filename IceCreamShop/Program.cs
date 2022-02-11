using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IceCreamShop.Interfaces;
using IceCreamShop.Stores;
using IceCreamShop.Components;
using IceCreamShop.Decorators;
using IceCreamShop.Constants;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            IShop superIceCream = new SuperIceCream();

            //CHOOSE ICECREAMFLAVOR OF CHOCOLATE TO GET THE SUPER CHOCOLATE PROMO (OuO)
            //IIceCream iceCream = new IceCream(1.9, Constant.IceCreamFlavors.Chocolate);
            IIceCream iceCream = new IceCream(1.9,Constant.IceCreamFlavors.Lemmon);

            //ADD SOME SIDES
            iceCream = new fondueDecorator(iceCream, 0.5,Constant.fondues.WhiteChocolate);
            iceCream = new DrizzlingDecorator(iceCream, Constant.Drizzling.Chocolate);
            iceCream = new DrizzlingDecorator(iceCream, Constant.Drizzling.Stars);
            iceCream = new fondueDecorator(iceCream, 0.7, Constant.fondues.RedVelvet);

            Console.WriteLine(superIceCream.Bill(iceCream));
            Console.ReadLine();
        }
    }
}
