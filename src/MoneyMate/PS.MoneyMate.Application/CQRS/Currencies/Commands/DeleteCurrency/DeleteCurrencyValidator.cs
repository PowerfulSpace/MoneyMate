using FluentValidation;

namespace PS.MoneyMate.Application.CQRS.Currencies.Commands.DeleteCurrency
{
    public class DeleteCurrencyValidator :AbstractValidator<DeleteCurrencyCommand>
    {
        public DeleteCurrencyValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Currency ID is required.");
        }
    }
}
