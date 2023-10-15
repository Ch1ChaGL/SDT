using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb1.Beverage
{
    class Espresso : Beverage
    {
        public Espresso()  { description = "Эспрессо"; }
        public override double GetCost()
        {
            return 17;
        }
    }
}
