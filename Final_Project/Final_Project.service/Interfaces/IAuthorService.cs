using Final_Project.service.Common;
using Final_Project.service.Dtos.AuthorDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.service.Interfaces
{
    public interface IAuthorService
    {

        CreatedResultDto Create(AuthorCreatDto dto);
        void Edit(int id, AuthorEditDto dto);
        AuthorGetDto GetById(int id);
        List<AuthorGetAllDto> GetAll();
        void Delete(int id);
    }
}
