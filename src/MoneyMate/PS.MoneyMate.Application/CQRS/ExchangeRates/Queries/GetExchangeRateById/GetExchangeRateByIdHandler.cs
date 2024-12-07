using MediatR;
using PS.MoneyMate.Application.Common.Interfaces.Persistence;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.CQRS.ExchangeRates.Queries.GetExchangeRateById
{
    public class GetExchangeRateByIdHandler : IRequestHandler<GetExchangeRateByIdQuery, ExchangeRate>
    {
        private readonly IExchangeRateRepository _repository;

        public GetExchangeRateByIdHandler(IExchangeRateRepository repository)
        {
            _repository = repository;
        }

        public async Task<ExchangeRate> Handle(GetExchangeRateByIdQuery request, CancellationToken cancellationToken)
        {
            var rate = await _repository.GetByIdAsync(request.Id);
            if (rate == null)
            {
                throw new KeyNotFoundException($"Exchange rate with ID {request.Id} not found.");
            }

            return rate;
        }
    }
}
