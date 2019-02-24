using BookEntity.Repository;
using BookEntity.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEntity.Service
{
    public class BaseService
    {
        protected IRepository _repository;
        protected IUnitOfWork _unitOfWork;
        public BaseService(IRepository repo,IUnitOfWork unit)
        {
            _repository = repo;
            _unitOfWork = unit;
        }
    }
}
