using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC5_Train.Data.Models
{
   public class Restaurant
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public CuisineType Cuisine { get; set; }
   }
}
