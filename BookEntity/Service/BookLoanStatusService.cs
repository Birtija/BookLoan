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
    public class BookLoanStatusService:BaseService
    {
        public BookLoanStatusService(IRepository repo,IUnitOfWork unit):base(repo,unit)
        {

        }

        public void InsertStatus (BookLoanStatus status)
        {
            _repository.Insert<BookLoanStatus>(status);
            _unitOfWork.CommitTransaction();
        }

        public IEnumerable<BookLoanStatus> GetAllStatus()
        {
          return  _repository.GetAll<BookLoanStatus>().ToList();
        }
    }
}
