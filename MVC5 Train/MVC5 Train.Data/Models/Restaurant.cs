using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

      [Required]
      [MaxLength(255)]
      public string Name { get; set; }
      
      [Display(Name="Type of food")]
      public CuisineType Cuisine { get; set; }
   }
}
