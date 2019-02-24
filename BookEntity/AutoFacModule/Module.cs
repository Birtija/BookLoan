using Autofac;
using BookEntity.Repository;
using BookEntity.Service;
using BookEntity.UOW;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace BookEntity.AutoFacModule
{
    public class BookRepositoryModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BookLoanDbContext>().InstancePerRequest();
            builder.RegisterType<EFBookLoanRepository>().As<IRepository>();
            builder.RegisterType<BookLoanUOW>().As<IUnitOfWork>();


            builder.RegisterAssemblyTypes(typeof(BaseService).Assembly)
                .PublicOnly().Where(t => t.Name.EndsWith("Service"));

        }
    }
}
