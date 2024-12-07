using FluentValidation;

namespace PS.MoneyMate.Application.CQRS.Currencies.Queries.GetCurrencyById
{
    public class GetCurrencyByIdValidator : AbstractValidator<GetCurrencyByIdQuery>
    {
        public GetCurrencyByIdValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Currency ID is required.");
        }
    }
}
