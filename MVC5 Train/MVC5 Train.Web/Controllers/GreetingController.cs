using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC5_Train.Web.Models;

namespace MVC5_Train.Web.Controllers
{
   public class GreetingController : Controller
   {
      public ActionResult Index(string name)
      {
         var model = new GreetingViewModel();
         model.Name = name ?? "no name";
         model.Message = ConfigurationManager.AppSettings.Get("message");
         return View(model);
      }
   }
}