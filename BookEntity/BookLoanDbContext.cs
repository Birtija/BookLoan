using BookEntity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEntity
{
    public class BookLoanDbContext : DbContext
    {
        public BookLoanDbContext():base("BookLoanDbConnectionStringName")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion
                <BookLoanDbContext, BookEntity.Migrations.Configuration>("BookLoanDbConnectionStringName"));
        }

        public virtual DbSet<BookLoanStatus> LoanStatuses { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<BookLoan> BookLoans { get; set; }
        public virtual DbSet<MMM> MMM { get; set; }
    }
}
