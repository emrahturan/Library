using System.Data.Entity;
using MyLibrary.Entities.Concrete;

namespace MyLibrary.DataAccess.Concrete.EntityFramework
{
    public class LibraryContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}
