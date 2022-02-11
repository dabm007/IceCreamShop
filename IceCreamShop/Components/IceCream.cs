using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IceCreamShop.Interfaces;
using IceCreamShop.Constants;

namespace IceCreamShop.Components
{
    public class IceCream : IIceCream
    {
        public double Price { get; set; }
        public double BasePrice { get; set; }
        public Constant.IceCreamFlavors Flavor { get; set; }
        public string Sides { get; set; }

        public IceCream(IceCream iceCream) {
            Price = iceCream.Price;
            BasePrice = iceCream.Price;
            Flavor = iceCream.Flavor;
            Sides = iceCream.Sides;
        }

        public IceCream(double price, Constant.IceCreamFlavors flavor) {
            Price = price;
            BasePrice = price;
            Flavor = flavor;
        }

        public void Charge()
        {
            //I DON'T KNOW WHAT TO DO
        }

        public string GetSides() {
            return Sides;
        }

        public void AddSide(string sideName, string variant, double price)
        {
            Price += price;
            Sides += sideName + " " + variant + ": " + price + Environment.NewLine;
        }

        public string GetFlavor()
        {
            return Flavor.ToString();
        }

        public double GetIceCreamPrice()
        {
            return BasePrice;
        }

        public double GetTotal()
        {
            return Price;
        }
    }
}
