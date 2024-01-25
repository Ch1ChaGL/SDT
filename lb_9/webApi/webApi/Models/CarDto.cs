using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webApi.Models
{
    public class CarDto
    {
        public int car_id { get; set; }
        public string name { get; set; }
        public Nullable<int> price { get; set; }
        public string buyerName { get; set; }
    }
}
