using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEntity.Repository
{
    public class EFBookLoanRepository : IRepository
    {
        private BookLoanDbContext _context;

        public EFBookLoanRepository()
        {

        }
        public EFBookLoanRepository(BookLoanDbContext context)
        {
            _context = context;
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Set<T>().Remove(entity);
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public IQueryable<T> GetAll<T>() where T : class
        {
            return _context.Set<T>();
            
        }

        public void Insert<T>(T entity) where T : class
        {
            _context.Set<T>().Add(entity);

        }
        
    }
}
