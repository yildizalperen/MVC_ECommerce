using ECommerce.DAL.Configurations;
using ECommerce.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Context
{
    public class ECommerceContext : IdentityDbContext<AppUser,AppUserRole,Guid>
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options) { }


        //DbSets
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //        optionsBuilder.UseSqlServer("Server=KDK-101-PC09-YZ;Database=MVC_ECommerce-P;Trusted_Connection=True;TrustServerCertificate=True");
        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //CategoryConfiguration
            builder.ApplyConfiguration(new CategoryConfiguration());
            //ProductConfiguration
            builder.ApplyConfiguration(new ProductConfiguration());
            //SupplierConfiguration
            builder.ApplyConfiguration(new SupplierConfiguration());
            //OrderDetailConfiguration
            builder.ApplyConfiguration(new OrderDetailConfiguration());
            //OrderConfiguration
            builder.ApplyConfiguration(new OrderConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
