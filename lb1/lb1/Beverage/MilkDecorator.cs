using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb1.Beverage
{
    class MilkDecorator : BeverageDecorator
    {
        public MilkDecorator(Beverage beverage) : base(beverage)
        {
        }

        public override double GetCost()
        {
            return beverage.GetCost() + 0.30;
        }

        public override string getDescrition()
        {
            return beverage.getDescrition() + ", с молоком";
        }

        public void RemoveMilk()
        {
            beverage = (beverage as MilkDecorator)?.beverage ?? beverage;
        }
    }
}
