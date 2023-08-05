//using AutoMapper;
//using Final_Project.core.Repositories;
//using Final_Project.service.Common;
//using Final_Project.service.Dtos.BookDtos;
//using Final_Project.service.Exceptions;
//using Final_Project.service.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Final_Project.service.Implementations
//{
//    public class BookService : IBookService
//    {
//        private readonly IBookRepositories _bookRepositories;
//        private readonly IAuthorRepositories _authorRepositories;
//        private readonly IGenreRepositories _genreRepositories;
//        private readonly IMapper _mapper;
//        private string _rootPath;

//        public BookService(IBookRepositories bookRepositories, IAuthorRepositories authorRepositories, IGenreRepositories genreRepositories,IMapper mapper)
//        {
            
//            _bookRepositories = bookRepositories;
//            _authorRepositories = authorRepositories;
//            _genreRepositories = genreRepositories;
//            _mapper = mapper;
//            _rootPath = Directory.GetCurrentDirectory()+ "/wwwroot";
//        }


//        public CreatedResultDto Create(BookCreatDto dto)
//        {
//            if (!_authorRepositories.IsExists(x => x.Id == dto.AuthorId))
//                throw new RestExceptions(System.Net.HttpStatusCode.BadRequest, "AuthorId", $"Author not found by id {dto.AuthorId}");
//            if(_bookRepositories.IsExists(x=>x.Name == dto.Name))
//                throw new RestExceptions(System.Net.HttpStatusCode.BadRequest, "Name " , "Name ")






//        }

//        public void Delete(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public void Edit(int id, BookEditDto dto)
//        {
//            throw new NotImplementedException();
//        }

//        public List<BookGetAllDto> GetAll()
//        {
//            throw new NotImplementedException();
//        }

//        public BookGetDto GetById(int id)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
