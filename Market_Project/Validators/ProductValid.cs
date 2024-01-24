﻿using data_access.Data.Entities;
using FluentValidation;

namespace Market_Project.Validators
{
    public class ProductValid : AbstractValidator<Product>
    {
        public ProductValid()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MinimumLength(2)
                .Matches("[A-Z].*").WithMessage("{PropertyName} must starts with uppercase letter.");
            RuleFor(x => x.CategoryId)
                .NotEmpty();
            RuleFor(x => x.Price)
                .NotEmpty()
                .GreaterThanOrEqualTo(0).WithMessage("{PropertyName} can not be negative.");

            RuleFor(x => x.Discount)
                .GreaterThanOrEqualTo(0).WithMessage("{PropertyName} can not be negative.");

            RuleFor(x => x.Description)
                .Length(10, 4000)
                .Matches("[A-Z].*").WithMessage("{PropertyName} must starts with uppercase letter.");

            RuleFor(x => x.ImageUrl)
                .NotEmpty()
                .Must(LinkMustBeAUri).WithMessage("{PropertyName} must be a valid URL address.");
        }
        private static bool LinkMustBeAUri(string link)
        {
            if (string.IsNullOrWhiteSpace(link))
            {
                return false;
            }

            Uri outUri;
            return Uri.TryCreate(link, UriKind.Absolute, out outUri) 
                && (outUri.Scheme == Uri.UriSchemeHttp || outUri.Scheme == Uri.UriSchemeHttps);
        }
        //asd//
    }
}
