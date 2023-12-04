using DetarikA.S_API.Configurations;
using DetarikA.S_API.Models.Entities;
using DetarikA.S_API.Models.Extensions;
using Microsoft.EntityFrameworkCore;

namespace DetarikA.S_API.Models.ContexClasses
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> opt):base(opt)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new DealerConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.CategorySeeds();
            modelBuilder.ProductSeeds();
            modelBuilder.DealerSeeds();


        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
