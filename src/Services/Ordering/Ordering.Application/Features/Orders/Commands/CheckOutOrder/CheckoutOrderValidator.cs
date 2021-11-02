using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Features.Orders.Commands.CheckOutOrder.CheckoutOrderValidator
{
    public class CheckoutOrderValidator: AbstractValidator<CheckOutOrderCommand>
    {
        public CheckoutOrderValidator()
        {
            RuleFor(z => z.UserName)
                .NotEmpty().WithMessage("{UserName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{UserName} must not exceed 50 characters.");
            
            RuleFor(z => z.EmailAddress)
                .NotEmpty().WithMessage("{EmailAddress} is required.");
            
            RuleFor(z => z.TotalPrice)
                .NotEmpty().WithMessage("{TotalPrice} is required.")
                .GreaterThan(0).WithMessage("{TotalPrice} should be greater than 0.");
        }
    }
}
