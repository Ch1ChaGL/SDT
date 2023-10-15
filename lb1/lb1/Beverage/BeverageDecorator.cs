using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lb1.Beverage
{
    abstract class BeverageDecorator : Beverage
    {
        protected Beverage beverage;
        public BeverageDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public void setBeverage(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public abstract override string getDescrition();
    }
}
