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
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(cu => cu.CustomerName).NotEmpty().WithMessage(CustomerMessages.CustomerNameCannotBeEmpty);
            RuleFor(cu => cu.CustomerName).MinimumLength(2).WithMessage(CustomerMessages.CustomerNameInvalid);
            RuleFor(cu => cu.CustomerName).Matches(@"^[a-zA-Z0-9\-']*$").WithMessage(CustomerMessages.CustomerNameInvalid);

            RuleFor(cu => cu.Phone).NotEmpty().WithMessage(CustomerMessages.PhoneNumberCannotBeEmpty);
            RuleFor(cu => cu.Phone).Matches("[0-9]").WithMessage(CustomerMessages.PhoneNumberInvalid);
            RuleFor(cu => cu.Phone).MinimumLength(10).WithMessage(CustomerMessages.PhoneNumberInvalid);

            RuleFor(cu => cu.CustomerCity).NotEmpty().WithMessage(CustomerMessages.CustomerCityCannotBeEmpty);
            RuleFor(cu => cu.CustomerCity).Matches(@"^[a-zA-Z-']*$").WithMessage(CustomerMessages.CustomerCityInvalid);

            RuleFor(cu => cu.Address).NotEmpty().WithMessage(CustomerMessages.AddressCannotBeEmpty);
            RuleFor(cu => cu.Address).Matches(@"^[a-zA-Z-']*$").WithMessage(CustomerMessages.CustomerAddressInvalid);

            RuleFor(cu => cu.Region).NotEmpty().WithMessage(CustomerMessages.RegionCannotBeEmpty);
            RuleFor(cu => cu.Region).Matches(@"^[a-zA-Z-']*$").WithMessage(CustomerMessages.CustomerRegionInvalid);

            RuleFor(cu => cu.Country).NotEmpty().WithMessage(CustomerMessages.CountryCannotBeEmpty);
            RuleFor(cu => cu.Country).Matches(@"^[a-zA-Z-']*$").WithMessage(CustomerMessages.CustomerCountryInvalid);

            RuleFor(cu => cu.PostalCode).NotEmpty().WithMessage(CustomerMessages.PostalCodeCannotBeEmpty);
            RuleFor(cu => cu.PostalCode).Matches("[0-9]").WithMessage(CustomerMessages.CustomerPostalCodeInvalid);
        }
    }
}
