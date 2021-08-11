﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC5_Train.Data.Models;

namespace MVC5_Train.Data.Services
{
   public interface IRestaurantData
   {
      IEnumerable<Restaurant> GetAll();

      Restaurant Get(int id);

      void Add(Restaurant restaurant);
      void Update(Restaurant restaurant);
      void Delete(int id);
   }
}
