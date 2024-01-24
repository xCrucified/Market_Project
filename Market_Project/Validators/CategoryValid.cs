using data_access.Data.Entities;
using FluentValidation;

namespace Market_Project.Validators
{
    public class CategoryValid : AbstractValidator<Category>
    {
        public CategoryValid()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MinimumLength(2)
                .Matches("[A-Z].*").WithMessage("{PropertyName} must starts with uppercase letter.");
        }
    }
}
