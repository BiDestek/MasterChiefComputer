using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Constants.Messages;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductImageValidator : AbstractValidator<ProductImage>
    {
        public ProductImageValidator()
        {
            RuleFor(p => p.ProductId).NotEmpty().WithMessage(ProductImagesMessages.ProductIdCannotBeEmpty);
            RuleFor(p => p.ProductId).GreaterThan(0).WithMessage(ProductImagesMessages.ProductIdCannotBeNegativeValue);

            RuleFor(p => p.ImageName).NotEmpty().WithMessage(ProductImagesMessages.ProductImageNameCannotBeEmpty);
            RuleFor(p => p.ImageName).Length(1, 30).WithMessage(ProductImagesMessages.ProductImageNameInvalid);
            RuleFor(p => p.ImageName).Matches(@"^[a-zA-Z0-9\-']*$").WithMessage(ProductImagesMessages.ProductImageNameInvalid);

            RuleFor(p => p.ImagePath).NotEmpty().WithMessage(ProductImagesMessages.ProductImagePathCannotBeEmpty);
        }
    }
}
