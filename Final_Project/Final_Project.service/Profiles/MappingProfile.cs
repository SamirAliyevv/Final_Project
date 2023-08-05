using AutoMapper;
using Final_Project.core.Entities;
using Final_Project.service.Dtos.AuthorDtos;
using Final_Project.service.Dtos.BookDtos;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.service.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile(IHttpContextAccessor _httpContextAccessor)
        {
            var baseUrl = new UriBuilder(_httpContextAccessor.HttpContext.Request.Scheme, _httpContextAccessor.HttpContext.Request.Host.Host, _httpContextAccessor.HttpContext.Request.Host.Port ?? -1);
            CreateMap<AuthorCreatDto, Author>();
            CreateMap<Author, AuthorGetDto>();
            CreateMap<Author, AuthorGetAllDto>();
            CreateMap<BookCreatDto, Book>();
            CreateMap<Author, BookGetDtoAuthorIn>();
            CreateMap<Book,BookGetDto>()
                .ForMember(d=>d.Profit, s=>s.MapFrom(m=>m.SalePrice-m.CostPrice))
                .ForMember(d=>d.ImageUrl,s=>s.MapFrom(m=>baseUrl+"uploads/books" + m.ImageName));

            CreateMap<Book, BookGetAllDto>()
                .ForMember(d => d.ImageUrl, s => s.MapFrom(m => string.IsNullOrWhiteSpace(m.ImageName) ? null : (baseUrl + "uploads/books" + m.ImageName)));

        }

    }
}
