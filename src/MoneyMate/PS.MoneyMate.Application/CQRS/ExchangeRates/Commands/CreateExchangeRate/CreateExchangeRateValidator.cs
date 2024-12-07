using FluentValidation;

namespace PS.MoneyMate.Application.CQRS.ExchangeRates.Commands.CreateExchangeRate
{
    public class CreateExchangeRateValidator : AbstractValidator<CreateExchangeRateCommand>
    {
        public CreateExchangeRateValidator()
        {
            RuleFor(x => x.FromCurrencyId)
                .NotEmpty().WithMessage("FromCurrencyId is required.");

            RuleFor(x => x.ToCurrencyId)
                .NotEmpty().WithMessage("ToCurrencyId is required.");

            RuleFor(x => x.Rate)
                .GreaterThan(0).WithMessage("Rate must be greater than zero.");
        }
    }
}
