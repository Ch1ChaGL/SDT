using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lb2.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Title = "MyCafe";
            return View();
        }
        [HttpGet]
        public ViewResult DrinkForm()
        {
            ViewBag.Title = "Drinks";
            return View();
        }

        [HttpPost]
        public ViewResult DrinkForm(Models.DrinkData drinkData)
        {
            ViewBag.Title = "Bill";
            double cost = 0.0;

            var type = drinkData.DrinkType;
            if (type == Models.DrinkType.Alcohol) cost += drinkData.AlcoholCost;
            if (type == Models.DrinkType.Coffee) cost += drinkData.CoffeeCost;
            if (type == Models.DrinkType.Juice) cost += drinkData.JuiceCost;
            if (type == Models.DrinkType.Tea) cost += drinkData.TeaCost;

            cost += drinkData.Sugar * drinkData.SugarCost;
            cost += drinkData.Milk * drinkData.MilkCost;

            ViewBag.Cost = cost;

            return View("Bill", drinkData);
        }


    }
}