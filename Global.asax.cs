using BLL.UserController;
using DAL.UserController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Unity;
using Unity.AspNet.WebApi;
using WebAPI1.Models;

namespace WebAPI1
{
    
    public class WebApiApplication : System.Web.HttpApplication
    {
        
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RegisterUnityContainer();
        }

        private void RegisterUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IUserControllerBL, UserControllerBL>();
            container.RegisterType<IUserControllerDB, UserControllerDB>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
