using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;
using webApi.Models;

namespace webApi.Controllers
{
    public class BuyerController : ApiController
    {
        static readonly IBuyerRepository repository = new BuyerRepository();

        public IEnumerable<Buyer> GetAllBuyer()
        {
            return repository.GetAll();
        }

        public Buyer GetBuyer(int id)
        {
            Buyer item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        //public IEnumerable<Car> GetProductsByCategory(string category)
        //{
        //    return repository.GetAll().Where(
        //        p => string.Equals(p.Category, category, StringComparison.OrdinalIgnoreCase));
        //}

        public HttpResponseMessage PostBuyer(Buyer item)
        {
            item = repository.Add(item);
            var response = Request.CreateResponse<Buyer>(HttpStatusCode.Created, item);

            string uri = Url.Link("DefaultApi", new { id = item.buyer_id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        public void PutBuyer(int id, Buyer buyer)
        {
            buyer.buyer_id = id;
            if (!repository.Update(buyer))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        public void DeleteCar(int id)
        {
            repository.Remove(id);
        }
    }
}