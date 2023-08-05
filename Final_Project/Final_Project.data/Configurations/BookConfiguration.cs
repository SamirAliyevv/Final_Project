using Final_Project.core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.data.Configurations
{
    public  class BookConfiguration:IEntityTypeConfiguration<Book>
    {
        public  void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(x=>x.Page).HasMaxLength(50);
            builder.Property(x=>x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.SalePrice > x.CostPrice);
            builder.Property(x=>x.Description).HasMaxLength(500);
            builder.Property(x=>x.SalePrice<1000).HasColumnType("money");
        }

    }
}
