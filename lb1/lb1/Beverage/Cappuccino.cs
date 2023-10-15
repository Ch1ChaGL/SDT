using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb1.Beverage
{
    class Cappuccino : Beverage
    {
        public Cappuccino() {
            description = "Капучино";
        }
        public override double GetCost()
        {
            return 15;
        }
    }
}
