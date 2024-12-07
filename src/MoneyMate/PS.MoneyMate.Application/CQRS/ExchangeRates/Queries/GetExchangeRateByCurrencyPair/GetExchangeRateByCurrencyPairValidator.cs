using FluentValidation;

namespace PS.MoneyMate.Application.CQRS.ExchangeRates.Queries.GetExchangeRateByCurrencyPair
{
    public class GetExchangeRateByCurrencyPairValidator : AbstractValidator<GetExchangeRateByCurrencyPairQuery>
    {
        public GetExchangeRateByCurrencyPairValidator()
        {
            RuleFor(x => x.FromCurrencyId).NotEmpty().WithMessage("FromCurrencyId is required.");
            RuleFor(x => x.ToCurrencyId).NotEmpty().WithMessage("ToCurrencyId is required.");
        }
    }
}
