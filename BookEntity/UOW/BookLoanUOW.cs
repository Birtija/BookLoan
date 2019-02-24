using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEntity.UOW
{
    public class BookLoanUOW : IUnitOfWork
    {
        private BookLoanDbContext _context;
        public BookLoanUOW(BookLoanDbContext context)
        {
            _context = context;
        }
        public void CommitTransaction()
        {
            
            var r=   _context.SaveChanges();
           
        }

        public void Dispose()
        {
            if (_context != null)
                _context.Dispose();
        }

        public void StartTransaction()
        {
        }
    }
}
