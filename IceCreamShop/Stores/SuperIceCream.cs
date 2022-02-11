using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IceCreamShop.Interfaces;

namespace IceCreamShop.Stores
{
    public class SuperIceCream : IShop
    {
        public SuperIceCream() {

        }

        public string Bill(IIceCream iceCream)
        {
            if (iceCream != null)
            {
                //DECORATOR TRIGGER
                iceCream.Charge();
                return iceCream.GetFlavor() + " ice cream: " + iceCream.GetIceCreamPrice() + Environment.NewLine + iceCream.GetSides() + Environment.NewLine + "Total: " + iceCream.GetTotal();
            }
            else {
                return "There's not products to charge";
            }
        }
    }
}
