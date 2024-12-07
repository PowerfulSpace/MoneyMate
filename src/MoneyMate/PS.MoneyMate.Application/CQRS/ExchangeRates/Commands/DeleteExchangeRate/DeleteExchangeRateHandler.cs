using MediatR;
using PS.MoneyMate.Application.Common.Interfaces.Persistence;

namespace PS.MoneyMate.Application.CQRS.ExchangeRates.Commands.DeleteExchangeRate
{
    public class DeleteExchangeRateHandler : IRequestHandler<DeleteExchangeRateCommand, Guid>
    {
        private readonly IExchangeRateRepository _repository;

        public DeleteExchangeRateHandler(IExchangeRateRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(DeleteExchangeRateCommand request, CancellationToken cancellationToken)
        {
            var existingRate = await _repository.GetByIdAsync(request.Id);
            if (existingRate == null)
            {
                throw new KeyNotFoundException($"Exchange rate with ID {request.Id} not found.");
            }

            await _repository.DeleteAsync(request.Id);
            return request.Id;
        }
    }
}
