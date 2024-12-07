using FluentValidation;

namespace PS.MoneyMate.Application.CQRS.ConversionRequests.Commands.DeleteConversionRequest
{
    public class DeleteConversionRequestValidator : AbstractValidator<DeleteConversionRequestCommand>
    {
        public DeleteConversionRequestValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("ID is required.");
        }
    }
}
