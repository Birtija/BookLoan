using BookEntity.Model;
using BookEntity.Repository;
using BookEntity.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEntity.Service
{
    public class BookService :BaseService
    {
        public BookService(IRepository repo, IUnitOfWork unit) : base(repo, unit)
        {

        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _repository.GetAll<Book>();
        }

        public void InsertBook (Book book)
        {
            _repository.Insert<Book>(book);
        }
    }
}
