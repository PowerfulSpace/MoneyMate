using Mapster;
using MediatR;
using PS.MoneyMate.Application.Common.Interfaces.Persistence;

namespace PS.MoneyMate.Application.CQRS.ConversionRequests.Commands.UpdateConversionRequest
{
    public class UpdateConversionRequestHandler : IRequestHandler<UpdateConversionRequestCommand, Guid>
    {
        private readonly IConversionRequestRepository _repository;

        public UpdateConversionRequestHandler(IConversionRequestRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(UpdateConversionRequestCommand request, CancellationToken cancellationToken)
        {
            var existingRequest = await _repository.GetByIdAsync(request.Id);
            if (existingRequest == null)
            {
                throw new KeyNotFoundException($"Conversion request with ID {request.Id} not found.");
            }

            // Map updated values onto the existing entity
            request.Adapt(existingRequest);

            await _repository.UpdateAsync(existingRequest);
            return existingRequest.Id;
        }
    }
}
