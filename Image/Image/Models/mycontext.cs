using Microsoft.EntityFrameworkCore;

namespace Image.Models
{
    public class mycontext:DbContext
    {
        public mycontext(DbContextOptions<mycontext> options):base (options) {
            
           
        
        }
        public DbSet<Product> Products { get; set; }

    }
}
