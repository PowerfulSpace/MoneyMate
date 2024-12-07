using Mapster;
using MediatR;
using PS.MoneyMate.Application.Common.Interfaces.Persistence;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.CQRS.ConversionRequests.Commands.CreateConversionRequest
{
    public class CreateConversionRequestHandler : IRequestHandler<CreateConversionRequestCommand, Guid>
    {
        private readonly IConversionRequestRepository _repository;

        public CreateConversionRequestHandler(IConversionRequestRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(CreateConversionRequestCommand request, CancellationToken cancellationToken)
        {
            var conversionRequest = request.Adapt<ConversionRequest>();
            await _repository.AddAsync(conversionRequest);
            return conversionRequest.Id;
        }
    }
}
