using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using DotNetStarterKit.Models;
using DotNetStarterKit.Models.Interfaces;

namespace DotNetStarterKit
{
    public class AutofacConfig
    {

        public static void RegisterDependencyResolver(HttpConfiguration httpConfiguration)
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.Register(c => new UserRepository()).As<IUserRepository>().InstancePerRequest();

            var container = builder.Build();
            httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}