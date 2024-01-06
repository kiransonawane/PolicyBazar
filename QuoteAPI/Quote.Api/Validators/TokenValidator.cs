using FluentValidation;
using Quote.Application.Request;

namespace Quote.Api.Validators
{
    public class TokenValidator : AbstractValidator<TokenRequest>
    {
        public TokenValidator() {
            RuleFor(c => c.UserName)
                .NotEmpty()
                .WithMessage("Usename should not be blank");

            RuleFor(c => c.Secrete)
                .NotEmpty()
                .WithMessage("Secrete should not be blank");
        }
    }
}
