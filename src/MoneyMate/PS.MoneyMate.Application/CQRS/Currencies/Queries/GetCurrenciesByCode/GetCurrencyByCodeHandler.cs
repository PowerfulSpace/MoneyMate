using MediatR;
using PS.MoneyMate.Application.Common.Interfaces.Persistence;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.CQRS.Currencies.Queries.GetCurrenciesByCode
{
    public class GetCurrencyByCodeHandler : IRequestHandler<GetCurrencyByCodeQuery, Currency>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public GetCurrencyByCodeHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<Currency> Handle(GetCurrencyByCodeQuery request, CancellationToken cancellationToken)
        {
            var existingCurrency = await _currencyRepository.GetByCodeAsync(request.Code);

            if(existingCurrency == null)
            {
                throw new KeyNotFoundException($"Currency with Code {request.Code} not found.");
            }

            return existingCurrency;
        }
    }
}
