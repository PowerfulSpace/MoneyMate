using FluentValidation;

namespace PS.MoneyMate.Application.CQRS.ExchangeRates.Commands.UpdateExchangeRate
{
    public class UpdateExchangeRateValidator : AbstractValidator<UpdateExchangeRateCommand>
    {
        public UpdateExchangeRateValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("ID is required.");

            RuleFor(x => x.FromCurrencyId)
                .NotEmpty().WithMessage("FromCurrencyId is required.");

            RuleFor(x => x.ToCurrencyId)
                .NotEmpty().WithMessage("ToCurrencyId is required.");

            RuleFor(x => x.Rate)
                .GreaterThan(0).WithMessage("Rate must be greater than zero.");
        }
    }
}
