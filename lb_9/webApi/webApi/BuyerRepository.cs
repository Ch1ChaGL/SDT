using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using webApi.Models;

namespace webApi
{
    public class BuyerRepository : IBuyerRepository
    {
        public Buyer Add(Buyer item)
        {
            using (db_carEntity _db = new db_carEntity())
            {
                Buyer buyer = _db.Buyer.Add(item);
                _db.SaveChanges();
                return buyer;
            }
        }

        public Buyer Get(int id)
        {
            using (db_carEntity _db = new db_carEntity())
            {
                return _db.Buyer.Find(id);
            }
        }

        public IEnumerable<Buyer> GetAll()
        {
            using (db_carEntity _db = new db_carEntity())
            {
                return _db.Buyer.ToList();
            }

        }

        public void Remove(int id)
        {
            using (db_carEntity _db = new db_carEntity())
            {
                Buyer removeBuyer = _db.Buyer.Find(id);
                _db.Buyer.Remove(removeBuyer);
            }
        }

        public bool Update(Buyer item)
        {
            db_carEntity _db = new db_carEntity();
            var existingCar = _db.Buyer.Find(item.buyer_id);

            if (existingCar != null)
            {
                // Обновляем существующий объект данными из item
                _db.Entry(existingCar).CurrentValues.SetValues(item);
                _db.SaveChanges(); // Сохраняем изменения в базе данных
                return true;
            }
            else
            {
                return false; // Объект с указанным ключом не найден
            }
        }

    }
}