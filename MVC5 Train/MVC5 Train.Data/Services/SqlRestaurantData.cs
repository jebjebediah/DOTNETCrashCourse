using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC5_Train.Data.Models;

namespace MVC5_Train.Data.Services
{
   public class SqlRestaurantData : IRestaurantData
   {
      private readonly MVC5DbContext db;

      public SqlRestaurantData(MVC5DbContext db)
      {
         this.db = db;
      }

      public IEnumerable<Restaurant> GetAll()
      {
         return from r in db.Restaurants
                  orderby r.Name
                  select r;
      }

      public Restaurant Get(int id)
      {
         return db.Restaurants.FirstOrDefault(r => r.Id == id);
      }

      public void Add(Restaurant restaurant)
      {
         db.Restaurants.Add(restaurant);
         db.SaveChanges();
      }

      public void Update(Restaurant restaurant)
      {
         var entry = db.Entry(restaurant);
         entry.State = EntityState.Modified;
         db.SaveChanges();
      }

      public void Delete(int id)
      {
         var restaurant = db.Restaurants.Find(id);
         db.Restaurants.Remove(restaurant);
         db.SaveChanges();
      }
   }
}
