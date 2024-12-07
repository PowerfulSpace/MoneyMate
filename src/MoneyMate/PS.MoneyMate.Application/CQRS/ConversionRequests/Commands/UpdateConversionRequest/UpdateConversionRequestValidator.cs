using FluentValidation;

namespace PS.MoneyMate.Application.CQRS.ConversionRequests.Commands.UpdateConversionRequest
{
    public class UpdateConversionRequestValidator : AbstractValidator<UpdateConversionRequestCommand>
    {
        public UpdateConversionRequestValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("ID is required.");

            RuleFor(x => x.FromCurrencyId)
                .NotEmpty().WithMessage("FromCurrencyId is required.");

            RuleFor(x => x.ToCurrencyId)
                .NotEmpty().WithMessage("ToCurrencyId is required.");

            RuleFor(x => x.Amount)
                .GreaterThan(0).WithMessage("Amount must be greater than zero.");
        }
    }
}
