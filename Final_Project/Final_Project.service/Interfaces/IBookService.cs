using Final_Project.service.Common;
using Final_Project.service.Dtos.BookDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.service.Interfaces
{
    public interface IBookService
    {

        CreatedResultDto Create(BookCreatDto dto);

        void Edit(int id, BookEditDto dto);
        BookGetDto GetById(int id);
        List<BookGetAllDto> GetAll();
        void Delete(int id);    
    }
}
