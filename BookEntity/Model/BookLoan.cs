using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEntity.Model
{
    public class BookLoan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public User User { get; set; }

        public Book Book { get; set; }

        public DateTime? LoanDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public BookLoanStatus Status { get; set; }
    }
}
