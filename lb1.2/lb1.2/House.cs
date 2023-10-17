using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb1._2
{
    internal class House
    {
        private int _countFloor = 0;
        public House(int countFloor ) {
            _countFloor = countFloor;
        }
        public int getCountFloor()
        {
            return _countFloor;
        }
    }
}
