using Final_Project.service.Common;
using Final_Project.service.Dtos.AuthorDtos;
using Final_Project.service.Dtos.GenreDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.service.Interfaces
{
    public interface IGenreService
    {
        CreatedResultDto Create(GenreCreatDto dto);
        void Edit(int id, GenreEditDto dto);
        GenreGetDto GetById(int id);
        List<GenreGetAllDto> GetAll();
        void Delete(int id);
    }
}
