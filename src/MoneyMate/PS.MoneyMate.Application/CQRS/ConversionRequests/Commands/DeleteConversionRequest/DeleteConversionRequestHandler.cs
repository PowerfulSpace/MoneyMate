using MediatR;
using PS.MoneyMate.Application.Common.Interfaces.Persistence;

namespace PS.MoneyMate.Application.CQRS.ConversionRequests.Commands.DeleteConversionRequest
{
    public class DeleteConversionRequestHandler : IRequestHandler<DeleteConversionRequestCommand, Guid>
    {
        private readonly IConversionRequestRepository _repository;

        public DeleteConversionRequestHandler(IConversionRequestRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(DeleteConversionRequestCommand request, CancellationToken cancellationToken)
        {
            var existingRequest = await _repository.GetByIdAsync(request.Id);
            if (existingRequest == null)
            {
                throw new KeyNotFoundException($"Conversion request with ID {request.Id} not found.");
            }

            await _repository.DeleteAsync(request.Id);
            return request.Id;
        }
    }
}
