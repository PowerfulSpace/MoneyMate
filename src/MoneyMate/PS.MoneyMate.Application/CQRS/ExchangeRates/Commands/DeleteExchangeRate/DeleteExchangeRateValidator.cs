using FluentValidation;

namespace PS.MoneyMate.Application.CQRS.ExchangeRates.Commands.DeleteExchangeRate
{
    public class DeleteExchangeRateValidator : AbstractValidator<DeleteExchangeRateCommand>
    {
        public DeleteExchangeRateValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("ID is required.");
        }
    }
}
