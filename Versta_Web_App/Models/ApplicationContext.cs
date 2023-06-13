using Microsoft.EntityFrameworkCore;

namespace Versta_Web_App.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<CargoOrder> Orders { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
