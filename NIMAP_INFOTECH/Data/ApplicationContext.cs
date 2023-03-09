using Microsoft.EntityFrameworkCore;
using NIMAP_INFOTECH.Models;
using System.Data;

namespace NIMAP_INFOTECH.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>options):base(options) { }
        public DbSet<Product>Products { get; set; }
    }
}
