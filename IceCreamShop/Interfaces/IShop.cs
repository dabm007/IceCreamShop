using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamShop.Interfaces
{
    public interface IShop
    {
        string Bill(IIceCream iceCream);
    }
}
