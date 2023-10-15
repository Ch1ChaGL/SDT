using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb1.Beverage
{
    public abstract class Beverage
    {
        public Beverage(){}
        protected string description = "Неизвестный напиток";
        public virtual string getDescrition()
        {
            return description;
        }
        public abstract double GetCost();
    }
}
