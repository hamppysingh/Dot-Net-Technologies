using Microsoft.EntityFrameworkCore;
using Proj.Models;

namespace Proj.Repo
{
    public class BookContext:DbContext
    {
        public BookContext(DbContextOptions options):base(options) {
        
        
        }
        public DbSet<Book> Books { get; set; } 

    }
}
