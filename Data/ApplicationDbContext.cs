using FribergRentals.Data.Models;
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
        public DbSet<FribergRentals.Data.Models.User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasDiscriminator<string>("UserType")
                .HasValue<Customer>("Customer")
                .HasValue<Admin>("Admin");

            // Optionally, you can configure additional properties for Customer and Admin
            //modelBuilder.Entity<Customer>(c =>
            //{
            //    c.Property(e => e.CustomerOrders).IsRequired();
            //    // Configure other properties
            //});

        }

    }

}
