using lb3.Models;
using Ninject.Modules;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lb3.Infrastructure
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            //В данном случае создается только один экземпляр
            Bind<IValueCalculator>().To<LinqValueCalculator>().InRequestScope();

            //В этом случае создается два экземпляра на каждый параметр
            //Bind<IValueCalculator>().To<LinqValueCalculator>();

            //Привязка к свойству
            //Bind<IDiscountHelper>().To<DefaulDiscountHelper>().WithPropertyValue("DiscountSize", 50m);

            //Привязка к значению конструктора
            Bind<IDiscountHelper>().To<DefaulDiscountHelper>().WithConstructorArgument("discountParam", 10m);

            //Указание использовать класс FlexibleDiscountHelper как реализациию IDiscountHelper, при вызове LinqValueCalculator, таким образом отработает сначала первая привязка, а после нее эта
            Bind<IDiscountHelper>().To<FlexibleDiscountHelper>().WhenInjectedInto<LinqValueCalculator>();
        }
    }
}