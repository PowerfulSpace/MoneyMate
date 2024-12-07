using MediatR;
using PS.MoneyMate.Application.Common.Interfaces.Persistence;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.CQRS.ConversionRequests.Queries.GetConversionRequestById
{
    public class GetConversionRequestByIdHandler : IRequestHandler<GetConversionRequestByIdQuery, ConversionRequest>
    {
        private readonly IConversionRequestRepository _repository;

        public GetConversionRequestByIdHandler(IConversionRequestRepository repository)
        {
            _repository = repository;
        }

        public async Task<ConversionRequest> Handle(GetConversionRequestByIdQuery request, CancellationToken cancellationToken)
        {
            var conversionRequest = await _repository.GetByIdAsync(request.Id);
            if (conversionRequest == null)
            {
                throw new KeyNotFoundException($"Conversion request with ID {request.Id} not found.");
            }

            return conversionRequest;
        }
    }
}
