using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MVC5_Train.Data.Models;

namespace MVC5_Train.Data.Models
{
   public class Restaurant
   {
      public IEnumerable<Restaurant> Restaurants { get; set; }
      public int Id { get; set; }

      public string Name { get; set; }
      
      public CuisineType Cuisine { get; set; }
   }
}
