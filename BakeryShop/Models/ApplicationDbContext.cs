using Microsoft.EntityFrameworkCore;

namespace BakeryShop.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> pies { get; set; }

        
    }
}
