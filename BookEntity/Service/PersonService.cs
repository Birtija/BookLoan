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
   public class PersonService :BaseService
    {

        public PersonService(IRepository repo, IUnitOfWork unit) : base(repo, unit)
        {

        }

        public void Insert(User p)
        {
            _repository.Insert(p);
            _unitOfWork.CommitTransaction();
        }
    }
}
