using MediatR;
using PS.MoneyMate.Application.Common.Interfaces.Persistence;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.CQRS.ExchangeRates.Queries.GetExchangeRateByCurrencyPair
{
    public class GetExchangeRateByCurrencyPairHandler : IRequestHandler<GetExchangeRateByCurrencyPairQuery, ExchangeRate>
    {
        private readonly IExchangeRateRepository _repository;

        public GetExchangeRateByCurrencyPairHandler(IExchangeRateRepository repository)
        {
            _repository = repository;
        }

        public async Task<ExchangeRate> Handle(GetExchangeRateByCurrencyPairQuery request, CancellationToken cancellationToken)
        {
            var rate = await _repository.GetRateAsync(request.FromCurrencyId, request.ToCurrencyId);
            if (rate == null)
            {
                throw new KeyNotFoundException($"Exchange rate for currency pair ({request.FromCurrencyId}, {request.ToCurrencyId}) not found.");
            }

            return rate;
        }
    }
}
