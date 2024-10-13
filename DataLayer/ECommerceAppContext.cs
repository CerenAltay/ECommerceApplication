using ECommerceApplication.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ECommerceApplication.DataLayer
{
    public class ECommerceAppContext : DbContext
    {
        public ECommerceAppContext(DbContextOptions<ECommerceAppContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasKey(x => x.Id);

            modelBuilder.Entity<Product>().HasKey(x => x.Id);
            modelBuilder.Entity<Product>().HasOne(x => x.Category).WithMany().HasForeignKey(x => x.CategoryId);

            modelBuilder.Entity<OrderItem>().HasKey(x => x.Id);
            modelBuilder.Entity<OrderItem>().HasOne(x => x.Order).WithMany(x => x.Items).HasForeignKey(x => x.OrderId);
            modelBuilder.Entity<OrderItem>().HasOne(x => x.Product).WithMany().HasForeignKey(x => x.ProductId);

            modelBuilder.Entity<Order>().HasKey(x => x.Id);
            modelBuilder.Entity<Order>().HasOne<Customer>().WithMany(x => x.Orders).HasForeignKey(x => x.CustomerId);

            modelBuilder.Entity<Category>().HasKey(x => x.Id);
        }
    }
}
