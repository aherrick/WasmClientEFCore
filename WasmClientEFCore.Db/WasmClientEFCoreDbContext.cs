using Microsoft.EntityFrameworkCore;
using System;

namespace WasmClientEFCore.Db
{
    public class WasmClientEFCoreDbContext : DbContext
    {
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }

        public WasmClientEFCoreDbContext(DbContextOptions<WasmClientEFCoreDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed a couple of test records.
            modelBuilder.Entity<Order>().HasData(new Order { Id = 1, CustomerId = 100, CustomerName = "Herrick", OrderDate = DateTime.UtcNow });
            modelBuilder.Entity<OrderDetail>().HasData(new OrderDetail { Id = 1, OrderId = 1, ProductId = 50, Quantity = 10, Weight = 100 });
        }
    }
}