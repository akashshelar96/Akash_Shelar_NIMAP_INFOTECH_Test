using Microsoft.EntityFrameworkCore;
using NIMAP_INFOTECH.Models;
using System.Data;

namespace NIMAP_INFOTECH.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
    // public ApplicationContext(DbContextOptions<ApplicationContext>options):base(options) { }
    // public DbSet<Product>Products { get; set; }

}
