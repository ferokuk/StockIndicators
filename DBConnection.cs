using Microsoft.EntityFrameworkCore;

namespace StockIndicators
{
    internal class DBConnection : DbContext
    {
        public DbSet<MSFT> MSFT { get; set; } = null!;
        public DbSet<UBER> UBER { get; set; } = null!;
        public DbSet<AAPL> AAPL { get; set; } = null!;
        public DbSet<GOOGL> GOOGL { get; set; } = null!;
        public DbSet<TSLA> TSLA { get; set; } = null!;
        public DBConnection()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=stocks;Username=postgres;Password=1111");
        }
    }
}
