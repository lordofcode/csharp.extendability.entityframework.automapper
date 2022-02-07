using Microsoft.EntityFrameworkCore;

namespace ProductPortal.Implementation.Data
{
    public class DatabaseContext : ProductPortal.Data.DatabaseContext
    {
        public DatabaseContext(string connectionString) : base(connectionString)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CreateModel(modelBuilder);

            modelBuilder.Entity<Models.Product>()
                .HasDiscriminator<bool?>("Discriminator")
                .HasValue<Models.Product>(false)
                .HasValue<Models.Product>(true);

            modelBuilder.Entity<Models.Product>().ToTable("product");
        }

        private DbSet<Models.Product>? _products { get; set; }

        public override DbSet<T>? Products<T>() where T : class
        {
            return _products as DbSet<T>;
        }

    }
}
