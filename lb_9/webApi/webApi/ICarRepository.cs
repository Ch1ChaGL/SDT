using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webApi.Models;

namespace webApi
{
    interface ICarRepository
    {
        IEnumerable<CarDto> GetAll();
        IEnumerable<CarDto> Get(int id);
        Car Add(Car item);
        void Remove(int id);
        void Update(Car item);

    }
}
