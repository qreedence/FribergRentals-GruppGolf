using Microsoft.EntityFrameworkCore;

namespace FribergRentals.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<FribergRentals.Data.Models.Car> Cars { get; set; }
        public DbSet<FribergRentals.Data.Models.Customer> Customers { get; set; }
        public DbSet<FribergRentals.Data.Models.Admin> Admins { get; set; }
        public DbSet<FribergRentals.Data.Models.Order> Orders { get; set; }
        public DbSet<Models.Category> Categories { get; set; }
    }
}
