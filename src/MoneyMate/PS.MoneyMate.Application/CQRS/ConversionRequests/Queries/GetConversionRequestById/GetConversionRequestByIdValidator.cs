using FluentValidation;

namespace PS.MoneyMate.Application.CQRS.ConversionRequests.Queries.GetConversionRequestById
{
    public class GetConversionRequestByIdValidator : AbstractValidator<GetConversionRequestByIdQuery>
    {
        public GetConversionRequestByIdValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("ID is required.");
        }
    }
}
