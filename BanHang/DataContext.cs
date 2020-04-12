using System;
using System.Linq;
using BanHang.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BanHang {
    public class DataContext : DbContext {
        public DataContext (DbContextOptions<DataContext> options) : base (options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins{get;set;}
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

         protected override void OnModelCreating (ModelBuilder modelBuilder) {
            modelBuilder.Entity<Customer> ().ToTable ("Customer");
            modelBuilder.Entity<Product> ().ToTable ("Product");
            modelBuilder.Entity<Order> ().ToTable ("Order");
            modelBuilder.Entity<OrderDetail> ().ToTable ("OrderDetails");
            modelBuilder.Entity<Admin> ().ToTable ("Admin");
            modelBuilder.Entity<OrderDetail> ().HasKey (c => new { c.OrderID, c.ProductID });
         }

    }
}