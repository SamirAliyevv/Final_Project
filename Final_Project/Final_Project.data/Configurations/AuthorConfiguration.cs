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
    public class AuthorConfiguration:IEntityTypeConfiguration<Author>
    {
      

       public void Configure (EntityTypeBuilder<Author> builder)
        {
            builder.Property(x=>x.FullName).IsRequired().HasMaxLength(40);
        }
    }
}
