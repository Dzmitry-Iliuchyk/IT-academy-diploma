using FluentValidation;
using HW_cookie_autentification.Models.UserModels.UserDTOs;
using System.Text.RegularExpressions;

namespace HW_cookie_autentification.Validations
{
    public class RegisterDTOValidator : AbstractValidator<RegisterDTO>
    {
        public RegisterDTOValidator() 
        {
            RuleFor(x => x.Password)
                .MinimumLength(4).WithMessage("Lenth should be more than 4")
                .MaximumLength(20).WithMessage("Lenth should be less than 20")
                .NotEmpty().WithMessage("Password cannot be empty")                
                .Matches(new Regex(@"\w*")).WithMessage("Password allowed to use alphanumeric and _ characters!");

            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("Email must be correct")
                .NotEmpty().WithMessage("Password cannot be empty");

            RuleFor(x=>x.PasswordConfirm).Equal(x=>x.Password).WithMessage("Password weafasfffzFDGHwrtghujwerts");
        }
    }
}
