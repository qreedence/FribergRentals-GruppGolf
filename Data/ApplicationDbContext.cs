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
        public DbSet<FribergRentals.Data.Models.Customer> AppUsers { get; set; }
        public DbSet<FribergRentals.Data.Models.Admin> Admins { get; set; }
        public DbSet<FribergRentals.Data.Models.Order> Orders { get; set; }
    }
}
