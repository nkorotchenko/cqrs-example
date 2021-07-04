using Microsoft.EntityFrameworkCore;
using Simple.Ordering.Dal.Entities;
using Simple.Ordering.Dal.Extensions;

namespace Simple.Ordering.Dal
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
