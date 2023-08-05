using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.service.Dtos.AuthorDtos
{
    public class AuthorCreatDto
    {
        public string Name { get; set; }
    }

    public class AuthorCreatDtoValidator : AbstractValidator<AuthorCreatDto>
    {


        public AuthorCreatDtoValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(45);
        }
    }
}
