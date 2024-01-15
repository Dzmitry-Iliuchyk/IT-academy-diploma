using FluentValidation;
using HW_cookie_autentification.Models.ShopModels;

namespace HW_cookie_autentification.Validations
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(x => x.Name)
                .MinimumLength(2).WithMessage("Lenth should be more than 2")
                .MaximumLength(50).WithMessage("Lenth should be less than 50")
                .NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(x => x.ClientId)
                .GreaterThan(0).WithMessage("ClientId shold be more than 0")
                .NotNull()
                .NotEmpty();
        }
    }

}
