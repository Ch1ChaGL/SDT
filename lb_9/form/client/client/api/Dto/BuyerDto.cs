using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.api.Dto
{
    interface CarInfo
    {
        string name { get; set; }
        int price { get; set; }
    }
    internal class BuyerDto
    {
        public int buyer_id { get; set; }
        public string name { get; set; }

        public IEnumerable<CarInfo> cars { get; set; }
    }
}
