using MediatR;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.CQRS.ConversionRequests.Queries.GetAllConversionRequests
{
    public class GetAllConversionRequestsQuery : IRequest<IEnumerable<ConversionRequest>>
    {
    }
}
