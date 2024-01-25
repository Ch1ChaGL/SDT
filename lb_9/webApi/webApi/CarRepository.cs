using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using webApi.Models;

namespace webApi
{
    public class CarRepository : ICarRepository
    {
        public Car Add(Car item)
        {
            using (db_carEntity _db = new db_carEntity())
            {
                Car addedCar = _db.Car.Add(item);
                _db.SaveChanges();
                return addedCar;
            }
        }

        public IEnumerable<CarDto> Get(int id)
        {
            db_carEntity _db = new db_carEntity();

            var res = _db.Car.Where(c => c.car_id == id).SelectMany(c => c.Buyer, (c, b) => new CarDto
            {
                car_id = c.car_id,
                name = c.name,
                buyerName = b.name,
                price = c.price,
            }).ToList();

            return res;

        }

        public IEnumerable<CarDto> GetAll()
        {
            db_carEntity _db = new db_carEntity();

            List<CarDto> res = _db.Car
                .SelectMany(c => c.Buyer.DefaultIfEmpty(), // использование DefaultIfEmpty, чтобы включить машины без покупателей
                    (c, b) => new CarDto
                    {
                        car_id = c.car_id,
                        name = c.name,
                        buyerName = b != null ? b.name : null, // проверка на null для избежания ошибки NullReferenceException
                        price = c.price,
                    })
                .ToList();

            return res;
        }

        public void Remove(int id)
        {
            using (db_carEntity _db = new db_carEntity())
            {
                Car removeCar = _db.Car.Find(id);

                if (removeCar != null)
                {
                    _db.Car.Remove(removeCar);
                    _db.SaveChanges(); // Сохраняем изменения в базе данных
                }
                else
                {
                    throw new Exception("Ошибка");
                }
            }
        }

        public void Update(Car item)
        {
            using (db_carEntity _db = new db_carEntity())
            {
                // Найдите объект Car по car_id
                Car carToUpdate = _db.Car.Find(item.car_id);

                if (carToUpdate != null)
                {
                    // Обновите поля объекта Car
                    carToUpdate.name = item.name;
                    carToUpdate.price = item.price;

                    // Сохраните изменения в базе данных
                    _db.SaveChanges();
                }
                else
                {
                    throw new Exception("Car not found");
                }
            }
        }
    }
}