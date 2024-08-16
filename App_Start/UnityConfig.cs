using BLL.CityController;
using BLL.StateController;
using BLL.UserController;
using DAL.CityController;
using DAL.StateController;
using DAL.UserController;
using System;
using System.Web.Http;
using Unity;
using Unity.AspNet.WebApi;

namespace WebAPI1
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            
        }
        public static void RegisterUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IUserControllerBL, UserControllerBL>();
            container.RegisterType<IUserControllerDB, UserControllerDB>();

            container.RegisterType<ICityControllerBL, CityControllerBL>();
            container.RegisterType<ICityControllerDB, CityControllerDB>();

            container.RegisterType<IStateControlleBL, StateControllerBL>();
            container.RegisterType<IStateControllerDB, StateControllerDB>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}