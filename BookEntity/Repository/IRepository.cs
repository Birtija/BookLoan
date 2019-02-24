using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEntity.Repository
{
    public interface IRepository:IDisposable
    {
       
        IQueryable<T> GetAll<T>() where T : class;
        void Delete<T>(T entity) where T : class;

        void Insert<T>(T entity) where T : class;

    }
}
