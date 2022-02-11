using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamShop.Constants
{
    public class Constant
    {
        public enum Sides {
            fondue,
            Drizzling
        }

        public enum Drizzling {
            Regular,
            Stars,
            Dots,
            Chocolate
        }

        public enum IceCreamFlavors {
            Vanilla,
            Chocolate,
            Lemmon,
            Strawberry,
            Tangerine
        }

        public enum fondues {
            Chocolate,
            WhiteChocolate,
            CookiesAndCream,
            RedVelvet
        }
    }
}
