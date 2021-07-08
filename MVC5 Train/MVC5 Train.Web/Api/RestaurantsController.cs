using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;
using MVC5_Train.Data.Models;
using MVC5_Train.Data.Services;

namespace MVC5_Train.Web.Api
{
    public class RestaurantsController : ApiController
    {
       private readonly IRestaurantData db;

       public RestaurantsController(IRestaurantData db)
       {
          this.db = db;
       }

       public IEnumerable<Restaurant> Get()
       {
          var model = db.GetAll();
          return model;
       }
    }
}
