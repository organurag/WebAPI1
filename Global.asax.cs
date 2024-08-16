using BLL.CityController;
using BLL.StateController;
using BLL.UserController;
using DAL.CityController;
using DAL.StateController;
using DAL.UserController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Unity;
using Unity.AspNet.WebApi;


namespace WebAPI1
{
    
    public class WebApiApplication : System.Web.HttpApplication
    {
        
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            UnityConfig.RegisterUnityContainer();
        }

        
    }
}
