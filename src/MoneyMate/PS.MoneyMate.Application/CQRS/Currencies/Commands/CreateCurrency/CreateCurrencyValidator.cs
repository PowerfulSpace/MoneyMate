using FluentValidation;

namespace PS.MoneyMate.Application.CQRS.Currencies.Commands.CreateCurrency
{
    public class CreateCurrencyValidator : AbstractValidator<CreateCurrencyCommand>
    {
        public CreateCurrencyValidator()
        {
            RuleFor(x => x.Code)
               .NotEmpty().WithMessage("Currency code is required.")
               .Length(3).WithMessage("Currency code must be exactly 3 characters.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Currency name is required.")
                .MaximumLength(100).WithMessage("Currency name cannot exceed 100 characters.");

            RuleFor(x => x.Symbol)
                .MaximumLength(10).WithMessage("Currency symbol cannot exceed 10 characters.");
        }
    }
}
