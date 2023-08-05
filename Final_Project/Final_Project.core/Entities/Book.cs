using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.core.Entities
{
    public class Book:BaseTrackedEntity
    {  
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Description { get; set; }
        public int Page { get; set; }
        public int Hour { get; set; }
        public decimal TotalWordCount { get; set; }
        public decimal  CostPrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal DiscountPercent { get; set; }
        public string ImageName { get; set; }
        public string  PosterImage  { get; set; }
        public bool Ebook { get; set; }
        public bool inStock { get; set; }


        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        public Genre Genre { get; set; }
        public Author Author { get; set; }

    }
}
