using Microsoft.EntityFrameworkCore;
using Shopping.Data.Entities;

namespace Shopping.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Country>   Countries { get; set; }
        public DbSet<Branch>   Branches { get; set; }
        public DbSet<Measurement>   Measurements { get; set; }
        public DbSet<DocumentType>   DocumentTypes { get; set; }
        public DbSet<Taxes>   Taxes { get; set; }
        public DbSet<Categories>   Categories { get; set; }
        public DbSet<Departments>   Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Measurement>().HasIndex(m => m.Name).IsUnique();
            modelBuilder.Entity<Categories>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Departments>().HasIndex(d => d.Name).IsUnique();
            modelBuilder.Entity<Taxes>().HasIndex(t => t.Description).IsUnique();
        }

    }
}
