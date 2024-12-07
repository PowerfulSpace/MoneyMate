using Mapster;
using MediatR;
using PS.MoneyMate.Application.Common.Interfaces.Persistence;

namespace PS.MoneyMate.Application.CQRS.ExchangeRates.Commands.UpdateExchangeRate
{
    public class UpdateExchangeRateHandler : IRequestHandler<UpdateExchangeRateCommand, Guid>
    {
        private readonly IExchangeRateRepository _repository;

        public UpdateExchangeRateHandler(IExchangeRateRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(UpdateExchangeRateCommand request, CancellationToken cancellationToken)
        {
            var existingRate = await _repository.GetByIdAsync(request.Id);
            if (existingRate == null)
            {
                throw new KeyNotFoundException($"Exchange rate with ID {request.Id} not found.");
            }

            // Map updated values onto the existing entity
            request.Adapt(existingRate);

            await _repository.UpdateAsync(existingRate);
            return existingRate.Id;
        }
    }
}
