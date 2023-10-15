using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb1.Beverage
{
    class Cocoa : Beverage
    {
        public Cocoa() { description = "Какао"; }
        public override double GetCost()
        {
            return 30;
        }
    }
}
