using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.service.Dtos.BookDtos
{
    public class BookCreatDto
    {

        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Name { get; set; }

        public decimal SalePrice { get; set; }
        public decimal CostPrice { get; set; }
        public IFormFile ImageFile { get; set; }    


        public class BookCreatDtoValidator : AbstractValidator<BookCreatDto>
        {

            public BookCreatDtoValidator()
            {
                RuleFor(x=>x.Name).NotEmpty().MinimumLength(2).MaximumLength(50);
                RuleFor(x => x.CostPrice).GreaterThanOrEqualTo(0);
                RuleFor(x => x.SalePrice).GreaterThanOrEqualTo(x => x.CostPrice);
                RuleFor(x => x.AuthorId).GreaterThanOrEqualTo(1);
                RuleFor(x => x.GenreId).GreaterThanOrEqualTo(1);
                RuleFor(x => x).Custom((x, context) =>
                {
                    if (x.ImageFile != null)
                    {


                        if (x.ImageFile.Length > 2 * 1024 * 1024)
                            context.AddFailure("ImageFile", "Image file must be less or equal that 2MB");
                        if (x.ImageFile.ContentType != "image/png" && x.ImageFile.ContentType != "iamge/jpg")
                            context.AddFailure("ImageFile", "Image file must be png,jpg or jpeg");
                        
                    }


                });
             

            }
        }


    }
}
