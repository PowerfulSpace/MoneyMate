using Microsoft.EntityFrameworkCore;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Infrastructure.Persistence
{
    public class MoneyMateDbContext : DbContext
    {
        public MoneyMateDbContext(DbContextOptions<MoneyMateDbContext> options) : base(options)
        {
        }

        public DbSet<Currency> Currencies { get; set; } = null!;
        public DbSet<ConversionRequest> ConversionRequests { get; set; } = null!;
        public DbSet<ExchangeRate> ExchangeRates { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
