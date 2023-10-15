using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb1.Beverage
{
    class SugarDecorator : BeverageDecorator
    {
        public SugarDecorator(Beverage beverage) : base(beverage) { }
        public override double GetCost()
        {
            return beverage.GetCost() + 0.15;
        }

        public override string getDescrition()
        {
            return beverage.getDescrition() + ", c сахаром";
        }

        public void RemoveSugar()
        {
            beverage = (beverage as SugarDecorator)?.beverage ?? beverage;
        }
    }
}
