using Resolver;
using System.Web.Http;
using Unity;
using Unity.AspNet.WebApi;
using Util.Interfaces;

namespace Api.App_Start
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = BuildUnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        public static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IStrategyResolver, StrategyResolver>();

            RegisterTypes(container);
           // container.RegisterType<Initiate>();
            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            ComponentLoader.LoadContainer(container, ".\\bin", "Dep.*.dll");
            ComponentLoader.LoadContainer(container, ".\\bin", "Processor.dll");



        }
    }
}