using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.core.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string  FullName { get; set; }
        public List<Book> Books { get; set; }
    }
}
