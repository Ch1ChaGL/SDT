using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lb2.Models
{
    public enum DrinkType
    {
        Tea,
        Coffee,
        Juice, 
        Alcohol
    }
    public class DrinkData
    {
        public int TeaCost = 10;
        public int CoffeeCost = 15;
        public int JuiceCost = 20;
        public int AlcoholCost = 25;
        public double SugarCost = 0.25;
        public double MilkCost = 0.33;
        public DrinkType DrinkType { get; set; }
        public int Milk { get; set; }
        public int Sugar { get; set; }

    }
}