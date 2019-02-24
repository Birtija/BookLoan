using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEntity.Model
{
    public class Author : Person
    {
        public int CountryName { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
