using MediatR;
using PS.MoneyMate.Application.Common.Interfaces.Persistence;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.CQRS.ConversionRequests.Queries.GetConversionRequestsByDateRange
{
    public class GetConversionRequestsByDateRangeHandler : IRequestHandler<GetConversionRequestsByDateRangeQuery, IEnumerable<ConversionRequest>>
    {
        private readonly IConversionRequestRepository _repository;

        public GetConversionRequestsByDateRangeHandler(IConversionRequestRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ConversionRequest>> Handle(GetConversionRequestsByDateRangeQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetByDateRangeAsync(request.StartDate, request.EndDate);
        }
    }
}
