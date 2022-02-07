using Microsoft.EntityFrameworkCore;

namespace ProductPortal.Data.BaseClasses
{
    public abstract class BaseDatabaseContext : DbContext
    {
        public BaseDatabaseContext() 
        {
            _connectionString = String.Empty;
        }
        public string _connectionString { get; set; }

        public abstract DbSet<T>? Products<T>() where T : class;
        
        public abstract DbSet<T>? Categories<T>() where T : class;
    }
}
