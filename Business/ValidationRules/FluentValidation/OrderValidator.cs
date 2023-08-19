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
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(o => o.OrderDate).NotEmpty().WithMessage(OrderMessages.OrderDateCannotBeEmpty);

            RuleFor(o => o.CustomerId).NotEmpty().WithMessage(OrderMessages.CustomerIdCannotBeEmpty);
            RuleFor(o => o.CustomerId).GreaterThan(0).WithMessage(OrderMessages.CustomerIdGreaterThanZero);
            
        }
    }
}
