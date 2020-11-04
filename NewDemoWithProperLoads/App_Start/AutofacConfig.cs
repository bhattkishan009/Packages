using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace NewDemoWithProperLoads.App_Start
{
    public static class AutofacDependecyBuilder
    {

        public static void DependencyBuilder()
        {
            // Create the builder with which components/services are registered.
            var builder = new ContainerBuilder();

            builder.RegisterType<Repo>().As<IRepo>().InstancePerLifetimeScope();

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            //builder.RegisterAssemblyTypes( AppDomain.CurrentDomain. GetAssemblies())
            //                          .Where(t => t.GetCustomAttribute() != null)
            //                          .AsImplementedInterfaces()
            //                          .InstancePerRequest();

            builder.RegisterWebApiFilterProvider(GlobalConfiguration.Configuration);

            //Build the Container
            var container = builder.Build();

            //Configuring WebApi with Dependency Resolver
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);


        }

    }

    public interface IRepo
    {
        IEnumerable<string> Get();
    }

    public class Repo : IRepo
    {
        public IEnumerable<string> Get()
        {
            return new List<string>
            {
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit, ",
                "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. ",
                "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut ",
                "aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in ",
                "voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint ",
                "occaecat cupidatat non proident, sunt in culpa qui officia ",
                "deserunt mollit anim id est laborum."
            };
        }
    }
}
