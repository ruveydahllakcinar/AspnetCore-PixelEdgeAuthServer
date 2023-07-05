using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PixelEdgeAuthServer.CoreLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelEdgeAuthServer.DataLayer.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(product => product.ProductId); //Id atamasını buradan gerçekleştiririz.4
            builder.Property(product=>product.Name).IsRequired().HasMaxLength(200);
            builder.Property(product => product.Stock).IsRequired();
            builder.Property(product => product.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(product => product.UserId).IsRequired();

        }
    }
}
