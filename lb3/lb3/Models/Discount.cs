using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lb3.Models
{
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totalParam);
    }

    public class DefaulDiscountHelper : IDiscountHelper
    {
        
        public DefaulDiscountHelper(decimal discountParam)
        {
            DiscountSize = discountParam;
        }
        public decimal DiscountSize { get; set; }
        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (DiscountSize / 100m * totalParam));
        }

    }
}