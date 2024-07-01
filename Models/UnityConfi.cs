using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using BLL.UserController;
using DAL.UserController;
using Unity;
using Unity.AspNet.WebApi;

namespace WebAPI1.Models
{
    public static class UnityConfig
    {
        public static void RegisterComponent()
        {
            var container = new UnityContainer();

            container.RegisterType<IUserControllerBL, UserControllerBL>();
            container.RegisterType<IUserControllerDB, UserControllerDB>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

    }
}