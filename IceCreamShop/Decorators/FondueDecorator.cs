using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IceCreamShop.Interfaces;
using IceCreamShop.Components;
using IceCreamShop.Constants;

namespace IceCreamShop.Decorators
{
    public class fondueDecorator : BaseIceCreamDecorator
    {
        //OVERRIDING THE CONSTRUCTOR TO MAKE A SIMPLE PROMO OF RED VELVET fondue
        public fondueDecorator(IIceCream iceCream,double fonduePrice, Constant.fondues fondueFlavor):base(iceCream,Constant.Sides.fondue.ToString(), fondueFlavor.ToString(), fonduePrice) {
            if (fondueFlavor == Constant.fondues.RedVelvet) {
                fonduePrice = Math.Round(fonduePrice * 0.5, 1);
            }
        }
    }
}
