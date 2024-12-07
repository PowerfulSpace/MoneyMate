using FluentValidation;

namespace PS.MoneyMate.Application.CQRS.ExchangeRates.Queries.GetExchangeRateById
{
    public class GetExchangeRateByIdValidator : AbstractValidator<GetExchangeRateByIdQuery>
    {
        public GetExchangeRateByIdValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("ID is required.");
        }
    }
}
