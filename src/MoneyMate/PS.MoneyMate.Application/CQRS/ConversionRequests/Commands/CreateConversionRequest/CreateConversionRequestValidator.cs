using FluentValidation;

namespace PS.MoneyMate.Application.CQRS.ConversionRequests.Commands.CreateConversionRequest
{
    public class CreateConversionRequestValidator : AbstractValidator<CreateConversionRequestCommand>
    {
        public CreateConversionRequestValidator()
        {
            RuleFor(x => x.FromCurrencyId)
                .NotEmpty().WithMessage("FromCurrencyId is required.");

            RuleFor(x => x.ToCurrencyId)
                .NotEmpty().WithMessage("ToCurrencyId is required.");

            RuleFor(x => x.Amount)
                .GreaterThan(0).WithMessage("Amount must be greater than zero.");
        }
    }
}
