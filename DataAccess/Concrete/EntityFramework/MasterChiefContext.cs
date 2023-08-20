using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class MasterChiefContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=192.168.1.12;Database=MASTERCHIEFPC;User Id=masterchief;Password=&#t.rLoG");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(c => c.HasKey(c => c.CategoryId));
            modelBuilder.Entity<Customer>(cu => cu.HasKey(cu => cu.CustomerId));
            modelBuilder.Entity<Order>(o => o.HasKey(o => o.OrderId));
            modelBuilder.Entity<OrderDetail>(od => od.HasKey(od => od.OrderDetailId));
            modelBuilder.Entity<Product>(p => p.HasKey(p => p.ProductId));
            modelBuilder.Entity<ProductImage>(pi => pi.HasKey(pi => pi.ImageId));
            modelBuilder.Entity<Supplier>(s => s.HasKey(s => s.SupplierId));
            modelBuilder.Entity<User>(u => u.HasKey(u => u.UserId));
            modelBuilder.Entity<OperationClaim>(oc => oc.HasKey(oc=>oc.OcId));
            modelBuilder.Entity<UserOperationClaim>(uoc => uoc.HasKey(uoc=>uoc.UserOcId));
        }

    }
}
