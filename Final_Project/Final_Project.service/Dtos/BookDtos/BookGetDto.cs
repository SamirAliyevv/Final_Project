using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.service.Dtos.BookDtos
{
    public class BookGetDto
    {
        public string Name { get; set; }
        public decimal CostPrice { get; set; }  
        public decimal SalePrice { get; set; }  

        public decimal Profit { get; set; }

        public string  ImageUrl { get; set; }

      public BookGetDtoAuthorIn AuthorIn { get; set; }

    }
    public class BookGetDtoAuthorIn
    {
        public int Id { get; set; } 
        public string Name { get; set; }
    }
}
