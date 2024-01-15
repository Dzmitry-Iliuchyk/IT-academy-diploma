using FluentValidation;
using HW_cookie_autentification.Models.ShopModels;
using System.Text.RegularExpressions;

namespace HW_cookie_autentification.Validations
{
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(x => x.Name)
                .MinimumLength(2).WithMessage("Lenth should be more than 2")
                .MaximumLength(50).WithMessage("Lenth should be less than 50")
                .NotEmpty().WithMessage("Name cannot be empty");
        }
    }

}
