using ECommerce.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.CustomerAddress).IsRequired(true);
            builder.Property(X=>X.CustomerName).IsRequired(true);
            builder.Property(x => x.CustomerAddress).HasMaxLength(155);
            builder.Property(x => x.CustomerName).HasMaxLength(60);
        }
    }
}
