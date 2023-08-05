using Final_Project.core.Entities;
using Final_Project.data.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.data
{
    public class EbookDbContext:IdentityDbContext
    {
        public EbookDbContext(DbContextOptions <EbookDbContext> options):base(options) { }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookConfiguration).Assembly);
           
            base.OnModelCreating(modelBuilder);
        }



    }
}
