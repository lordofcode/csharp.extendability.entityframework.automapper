using Microsoft.EntityFrameworkCore;
using ProductPortal.Data.BaseClasses;
using ProductPortal.Data.Models;

namespace ProductPortal.Data
{
    /// <summary>
    /// This library works with data from a SQL database
    /// 
    /// </summary>
    public class DatabaseContext : BaseDatabaseContext
    {
        public DatabaseContext(string connectionString)
        { 
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(_connectionString);
        }

        public void CreateModel(ModelBuilder modelBuilder, bool useDummyDiscriminators = false)
        {
            modelBuilder.Entity<Product>().ToTable("product");
            modelBuilder.Entity<Category>().ToTable("category");

            if (!useDummyDiscriminators)
            {
                modelBuilder.Entity<Product>()
                .HasDiscriminator<bool?>("Discriminator")
                .HasValue<Product>(false);
            }
            else 
            {
                modelBuilder.Entity<Product>()
                .HasDiscriminator<bool?>("Discriminator")
                .HasValue<Product>(false)
                .HasValue<DummyProduct>(true);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            CreateModel(modelBuilder, true);
        }

        private DbSet<Category>? _categories { get; set; }

        private DbSet<Product>? _products { get; set; }

        public override DbSet<T>? Products<T>() where T: class
        {
            return _products as DbSet<T>;
        }

        public override DbSet<T>? Categories<T>() where T : class
        {
            return _categories as DbSet<T>;
        }
    }
}