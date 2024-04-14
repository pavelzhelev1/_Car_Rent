using DriveUp.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DriveUp.Data
{
    public class ApplicationDbContext : IdentityDbContext<RentACarUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Car { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure one-to-many relationship between User and Car
            modelBuilder.Entity<Car>()
                .HasOne(c => c.User)               // Car has one User
                .WithMany(u => u.Cars)             // User has many Cars
                .HasForeignKey(c => c.UserId);    // Use UserId as the foreign key

            base.OnModelCreating(modelBuilder);
        }
    }
}