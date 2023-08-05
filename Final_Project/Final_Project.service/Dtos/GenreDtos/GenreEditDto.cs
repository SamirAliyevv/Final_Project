using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.service.Dtos.GenreDtos
{
    public class GenreEditDto
    {
        public string  Name { get; set; }
    }

    public class GenreEditDtoValidator : AbstractValidator<GenreEditDto>
    {

        public GenreEditDtoValidator() 
        { 
            RuleFor(x=>x.Name).NotEmpty().MaximumLength(20);
        }
    }
}
