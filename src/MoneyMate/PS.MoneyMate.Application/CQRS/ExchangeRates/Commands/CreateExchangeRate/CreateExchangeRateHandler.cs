using Mapster;
using MediatR;
using PS.MoneyMate.Application.Common.Interfaces.Persistence;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.CQRS.ExchangeRates.Commands.CreateExchangeRate
{
    public class CreateExchangeRateHandler : IRequestHandler<CreateExchangeRateCommand, Guid>
    {
        private readonly IExchangeRateRepository _repository;

        public CreateExchangeRateHandler(IExchangeRateRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(CreateExchangeRateCommand request, CancellationToken cancellationToken)
        {
            var exchangeRate = request.Adapt<ExchangeRate>();
            await _repository.AddAsync(exchangeRate);
            return exchangeRate.Id;
        }
    }
}
