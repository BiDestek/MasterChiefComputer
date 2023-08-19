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
    public class OrderDetailValidator : AbstractValidator<OrderDetail>
    {
        public OrderDetailValidator()
        {
            RuleFor(od => od.UnitPrice).NotEmpty().WithMessage(OrderDetailMessages.UnitPriceCannotBeEmpty);
            RuleFor(od => od.UnitPrice).GreaterThan(0).WithMessage(OrderDetailMessages.UnitPriceCannotBeNegativeValue); ;
            
            RuleFor(od => od.Quantity).NotEmpty().WithMessage(OrderDetailMessages.QuantityCannotBeEmpty);
            
            RuleFor(od => od.Discount).GreaterThan(0).WithMessage(OrderDetailMessages.DiscountCannotBeNegativeValue);
        }
    }
}
