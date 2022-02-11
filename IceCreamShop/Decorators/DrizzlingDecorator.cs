using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IceCreamShop.Interfaces;
using IceCreamShop.Constants;

namespace IceCreamShop.Decorators
{
    public class DrizzlingDecorator : BaseIceCreamDecorator
    {
        public DrizzlingDecorator(IIceCream iceCream, Constant.Drizzling variant) : base(iceCream, Constant.Sides.Drizzling.ToString(), variant.ToString(), 0.5)
        {

        }

        //OVERRIDING THIS METHOD MAKE A SIMPLE CHOCOLATE PROMO
        public override void AddSide(string side, string variant, double price)
        {
            Constant.Sides enumSide = (Constant.Sides)Enum.Parse(typeof(Constant.Sides), side);

            if (enumSide == Constant.Sides.Drizzling)
            {
                Constant.Drizzling enumVariant = (Constant.Drizzling)Enum.Parse(typeof(Constant.Drizzling), variant);

                string iceCreamFlavor = GetFlavor();

                //PROMO CHOCOLATE
                if (enumVariant == Constant.Drizzling.Chocolate && iceCreamFlavor == Constant.IceCreamFlavors.Chocolate.ToString())
                {
                    price = Math.Round(price * 0.5, 1);
                    variant = variant + " 50% off";
                }

                base.AddSide(side, variant, price);
            }
        }
    }
}
