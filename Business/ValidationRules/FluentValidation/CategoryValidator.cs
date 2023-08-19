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
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.CategoryName).NotEmpty().WithMessage(CategoryMessages.CategoryNameCannotBeEmpty);
            RuleFor(c => c.CategoryName).MinimumLength(2).WithMessage(CategoryMessages.CategoryNameInvalid);
            RuleFor(c => c.CategoryName).Matches(@"^[a-zA-Z-']*$").WithMessage(CategoryMessages.CategoryNameInvalid);

            RuleFor(c => c.Description).NotEmpty().WithMessage(CategoryMessages.CategoryDescriptionCannotBeEmpty);
            RuleFor(c => c.Description).Matches(@"^[a-zA-Z0-9\-']*$").WithMessage(CategoryMessages.CategoryDescriptionInvalid);
        }
    }
}
