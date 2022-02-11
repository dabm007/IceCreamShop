using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamShop.Interfaces
{
    public interface IIceCream
    {
        void Charge();
        string GetSides();
        string GetFlavor();
        double GetIceCreamPrice();
        double GetTotal();
        void AddSide(string sideName, string variant, double price);
    }
}
