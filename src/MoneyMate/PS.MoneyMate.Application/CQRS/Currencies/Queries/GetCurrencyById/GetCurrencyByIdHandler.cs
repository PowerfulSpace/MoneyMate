using MediatR;
using PS.MoneyMate.Application.Common.Interfaces.Persistence;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.CQRS.Currencies.Queries.GetCurrencyById
{
    public class GetCurrencyByIdHandler : IRequestHandler<GetCurrencyByIdQuery, Currency>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public GetCurrencyByIdHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<Currency> Handle(GetCurrencyByIdQuery request, CancellationToken cancellationToken)
        {
            var existingCurrency = await _currencyRepository.GetByIdAsync(request.Id);
            if(existingCurrency == null)
            {
                throw new KeyNotFoundException($"Currency with ID {request.Id} not found.");
            }

            return existingCurrency;
        }
    }
}
