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
    public class BaseIceCreamDecorator : IIceCream
    {
        private IIceCream IceCream;

        public BaseIceCreamDecorator() {

        }

        public BaseIceCreamDecorator(IIceCream iceCream, string sideName, string variant, double price) {
            IceCream = iceCream;
        }

        public virtual void Charge()
        {
            IceCream.Charge();
        }

        public virtual void AddSide(string side, string variant, double price)
        {
            IceCream.AddSide(side, variant, price);
        }

        public string GetSides()
        {
            return IceCream.GetSides();
        }

        public string GetFlavor() {
            return IceCream.GetFlavor();
        }

        public double GetIceCreamPrice()
        {
            return IceCream.GetIceCreamPrice();
        }

        public double GetTotal()
        {
            return IceCream.GetTotal();
        }
    }
}
