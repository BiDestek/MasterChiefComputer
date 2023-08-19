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
    public class SupplierValidator : AbstractValidator<Supplier>
    {
        public SupplierValidator()
        {
            RuleFor(s => s.CompanyName).NotEmpty().WithMessage(SupplierMessages.SupplierCompanyNameCannotBeEmpty);
            RuleFor(s => s.CompanyName).MinimumLength(2).WithMessage(SupplierMessages.SupplierCompanyNameInvalid);
            RuleFor(s => s.CompanyName).Matches(@"^[a-zA-Z0-9\-']*$").WithMessage(SupplierMessages.SupplierCompanyNameInvalid);

            RuleFor(s => s.ContactName).NotEmpty().WithMessage(SupplierMessages.SupplierContactNameCannotBeEmpty);
            RuleFor(s => s.ContactName).MinimumLength(2).WithMessage(SupplierMessages.SupplierContactNameInvalid);
            RuleFor(s => s.ContactName).Matches(@"^[a-zA-Z0-9\-']*$").WithMessage(SupplierMessages.SupplierContactNameInvalid);

            RuleFor(s => s.SupplierCity).NotEmpty().WithMessage(SupplierMessages.SupplierCityCannotBeEmpty);
            RuleFor(s => s.SupplierCity).MinimumLength(2).WithMessage(SupplierMessages.SupplierCityInvalid);
            RuleFor(s => s.SupplierCity).Matches(@"^[a-zA-Z-']*$").WithMessage(SupplierMessages.SupplierCityInvalid);

            RuleFor(s => s.ContactTitle).NotEmpty().WithMessage(SupplierMessages.SupplierContactTitleCannotBeEmpty);
            RuleFor(s => s.ContactTitle).MinimumLength(2).WithMessage(SupplierMessages.SupplierContactTitleInvalid);
            RuleFor(s => s.ContactTitle).Matches(@"^[a-zA-Z-']*$").WithMessage(SupplierMessages.SupplierContactTitleInvalid);

            RuleFor(s => s.Address).NotEmpty().WithMessage(SupplierMessages.SupplierAddressCannotBeEmpty);
            RuleFor(s => s.Address).MinimumLength(2).WithMessage(SupplierMessages.SupplierAddressInvalid);
            RuleFor(s => s.Address).Matches(@"^[a-zA-Z-']*$").WithMessage(SupplierMessages.SupplierAddressInvalid);

            RuleFor(s => s.Phone).NotEmpty().WithMessage(SupplierMessages.SupplierPhoneNumberCannotBeEmpty);
            RuleFor(s => s.Phone).MinimumLength(10).WithMessage(SupplierMessages.SupplierPhoneNumberInvalid);
            RuleFor(s => s.Phone).Matches("[0-9]").WithMessage(SupplierMessages.SupplierPhoneNumberInvalid);

        }
    }
}
