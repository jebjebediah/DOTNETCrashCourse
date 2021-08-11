using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using MVC5_Train.Data.Services;

namespace MVC5_Train.Web
{
   public class ContainerConfig
   {
      internal static void RegisterContainer(HttpConfiguration httpConfiguration)
      {
         var builder = new ContainerBuilder();

         builder.RegisterControllers(typeof(MvcApplication).Assembly);
         builder.RegisterType<SqlRestaurantData>().As<IRestaurantData>().InstancePerRequest();
         builder.RegisterApiControllers(typeof(MvcApplication).Assembly);
         builder.RegisterType<MVC5DbContext>().InstancePerRequest();

         var container = builder.Build();
         DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
         httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
      }
   }
}