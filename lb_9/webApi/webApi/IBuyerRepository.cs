using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webApi.Models;

namespace webApi
{
    interface IBuyerRepository
    {
        IEnumerable<Buyer> GetAll();
        Buyer Get(int id);
        Buyer Add(Buyer item);
        void Remove(int id);
        bool Update(Buyer item);
    }
}
