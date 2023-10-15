using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb1.Beverage
{
    class Americano : Beverage
    {
        public Americano(){
            description = "Американо";
        }
        public override double GetCost()
        {
            return 10;
        }
    }
}
