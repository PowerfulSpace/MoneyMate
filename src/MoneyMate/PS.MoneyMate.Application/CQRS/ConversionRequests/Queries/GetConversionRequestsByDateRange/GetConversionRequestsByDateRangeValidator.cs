using FluentValidation;

namespace PS.MoneyMate.Application.CQRS.ConversionRequests.Queries.GetConversionRequestsByDateRange
{
    public class GetConversionRequestsByDateRangeValidator : AbstractValidator<GetConversionRequestsByDateRangeQuery>
    {
        public GetConversionRequestsByDateRangeValidator()
        {
            RuleFor(x => x.StartDate)
                .NotEmpty().WithMessage("Start date is required.");

            RuleFor(x => x.EndDate)
                .NotEmpty().WithMessage("End date is required.");

            RuleFor(x => x)
                .Must(x => x.EndDate > x.StartDate).WithMessage("End date must be after start date.");
        }
    }
}
