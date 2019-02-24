using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEntity.Model
{
    public class User:Person
    {
        public string Email { get; set; }

        public ICollection<BookLoan> BookLoans { get; set; }
    }
}
