﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5_Train.Data.Services;

namespace MVC5_Train.Web.Controllers
{
   public class RestaurantsController : Controller
   {
      private readonly IRestaurantData db;

      public RestaurantsController(IRestaurantData db)
      {
         this.db = db;
      }

      public ActionResult Index()
      {
         var model = db.GetAll();
         return View(model);
      }

      public ActionResult Details(int id)
      {
         var model = db.Get(id);
         if (model == null)
         {
            return View("NotFound");
         }
         return View(model);
      }
   }
}