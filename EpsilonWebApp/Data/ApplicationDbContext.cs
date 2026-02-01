using Microsoft.EntityFrameworkCore;
using EpsilonWebApp.Shared.Models;

namespace EpsilonWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Εδώ μπορείς να ορίσεις αν κάποια πεδία είναι υποχρεωτικά ή έχουν περιορισμούς
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.ContactName).IsRequired();
            });
        }
    }
}
