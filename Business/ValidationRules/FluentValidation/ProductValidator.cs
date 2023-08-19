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
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {

            RuleFor(p => p.ProductName).NotEmpty().WithMessage(ProductMessages.ProductNameCannotBeEmpty);
            RuleFor(p => p.ProductName).MinimumLength(2).WithMessage(ProductMessages.ProductNameInvalid);
            RuleFor(p => p.ProductName).Matches(@"^[a-zA-Z0-9\-']*$").WithMessage(ProductMessages.ProductNameInvalid);

            RuleFor(p => p.UnitsOnOrder).NotEmpty().WithMessage(ProductMessages.UnitsOnOrderCannotBeEmpty);
            RuleFor(p => p.UnitsOnOrder).GreaterThan(0).WithMessage(ProductMessages.UnitsOnOrderCannotBeNegativeValue);

            RuleFor(p => p.UnitsInStock).NotEmpty().WithMessage(ProductMessages.UnitsInStockCannotBeEmpty);

            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage(ProductMessages.UnitPriceCannotBeEmpty);
            RuleFor(p => p.UnitPrice).GreaterThan(0).WithMessage(ProductMessages.UnitPriceCannotBeNegativeValue);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1)
                .WithMessage(ProductMessages.UnitPriceInvalidGreaterThanOrEqualTo);
        }
    }
}
