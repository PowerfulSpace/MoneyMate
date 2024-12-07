using FluentValidation;

namespace PS.MoneyMate.Application.CQRS.Currencies.Queries.GetCurrenciesByCode
{
    public class GetCurrencyByCodeValidator : AbstractValidator<GetCurrencyByCodeQuery>
    {
        public GetCurrencyByCodeValidator()
        {
            RuleFor(x => x.Code)
                .NotEmpty().WithMessage("Code is required");
        }
    }
}
