using System;
using System.Collections.Generic;
using System.Linq;
using MVC5_Train.Data.Models;

namespace MVC5_Train.Data.Services
{
   public class InMemoryRestaurantData : IRestaurantData
   {
      List<Restaurant> restaurants;

      public InMemoryRestaurantData()
      {
         restaurants = new List<Restaurant>()
         {
            new Restaurant {Id = 1, Name = "Scott's Pizza", Cuisine = CuisineType.Italian},
            new Restaurant {Id = 2, Name = "Indian Buffet", Cuisine = CuisineType.Indian},
            new Restaurant {Id = 3, Name = "Paris Restaurant", Cuisine = CuisineType.French}
         };
      }

      public IEnumerable<Restaurant> GetAll()
      {
         return restaurants.OrderBy(r => r.Name);
      }
   }
}