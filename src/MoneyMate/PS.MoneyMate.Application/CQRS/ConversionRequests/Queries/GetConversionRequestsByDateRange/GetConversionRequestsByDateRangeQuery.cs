using MediatR;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.CQRS.ConversionRequests.Queries.GetConversionRequestsByDateRange
{
    public class GetConversionRequestsByDateRangeQuery : IRequest<IEnumerable<ConversionRequest>>
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
