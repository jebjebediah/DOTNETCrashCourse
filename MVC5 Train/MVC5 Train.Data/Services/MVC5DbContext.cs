using System;
using System.Data.Entity;
using System.Linq;
using System.Text;
using MVC5_Train.Data.Models;

namespace MVC5_Train.Data.Services
{
   public class MVC5DbContext : DbContext
   {
      public DbSet<Restaurant> Restaurants { get; set; } 
   }
}
