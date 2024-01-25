using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using webApi.Models;
using Newtonsoft.Json;
using System.Web.Razor.Generator;

namespace webApi.Controllers
{
    public class CarController : ApiController
    {
        static readonly ICarRepository repository = new CarRepository();

        public IEnumerable<CarDto> GetAllCar()
        {
            var data = repository.GetAll();
            

            return data;
        }

        public IEnumerable<CarDto> GetCar(int id)
        {
            var item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            System.Diagnostics.Debug.WriteLine(item);
            return item;
        }

        //public IEnumerable<Car> GetProductsByCategory(string category)
        //{
        //    return repository.GetAll().Where(
        //        p => string.Equals(p.Category, category, StringComparison.OrdinalIgnoreCase));
        //}

        public HttpResponseMessage PostCar(Car item)
        {
            item = repository.Add(item);
            var response = Request.CreateResponse<Car>(HttpStatusCode.Created, item);

            string uri = Url.Link("DefaultApi", new { id = item.car_id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        public void PutCar(int id, Car car)
        {
            car.car_id = id;
            repository.Update(car);
            
        }

        public void DeleteCar(int id)
        {
            repository.Remove(id);
        }

    }
}