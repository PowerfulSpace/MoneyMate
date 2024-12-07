using MediatR;
using PS.MoneyMate.Application.Common.Interfaces.Persistence;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.CQRS.ConversionRequests.Queries.GetAllConversionRequests
{
    public class GetAllConversionRequestsHandler : IRequestHandler<GetAllConversionRequestsQuery, IEnumerable<ConversionRequest>>
    {
        private readonly IConversionRequestRepository _conversionRequestRepository;

        public GetAllConversionRequestsHandler(IConversionRequestRepository conversionRequestRepository)
        {
            _conversionRequestRepository = conversionRequestRepository;
        }

        public async Task<IEnumerable<ConversionRequest>> Handle(GetAllConversionRequestsQuery request, CancellationToken cancellationToken)
        {
            return await _conversionRequestRepository.GetAllAsync();
        }
    }
}
