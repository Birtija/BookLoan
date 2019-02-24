using Autofac;
using Autofac.Integration.Mvc;
using BookEntity;
using BookEntity.Repository;
using BookEntity.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookLoaning.DI
{
    public class IOCContainer
    {
        public static void Build()
        {
            var efAssembly = typeof(BookLoanDbContext).Assembly;
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterAssemblyModules(efAssembly);



            var container= builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            
        }
    }
}