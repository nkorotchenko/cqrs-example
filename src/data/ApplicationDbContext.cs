using Microsoft.EntityFrameworkCore;
using Simple.Ordering.Data.Extensions;
using Simple.Ordering.Domain;

namespace Simple.Ordering.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ToSnakeCaseConvention();
        }
    }
}
