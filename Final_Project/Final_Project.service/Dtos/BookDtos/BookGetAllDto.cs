using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.service.Dtos.BookDtos
{
    public class BookGetAllDto
    {
        public int Id { get; set; }
        public string  Name { get; set; }

        public string  ImageUrl { get; set; }

        public string  AuthorName { get; set; }
    }
}
