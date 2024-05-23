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

        //DbSets
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("server=DESKTOP-22DN80G;database=MVC_ECommerce;Trusted_Connection=True;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //CategoryConfiguration
            builder.ApplyConfiguration(new CategoryConfiguration());
            //ProductConfiguration
            builder.ApplyConfiguration(new ProductConfiguration());
            //SupplierConfiguration
            builder.ApplyConfiguration(new SupplierConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
