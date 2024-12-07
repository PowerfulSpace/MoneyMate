using MediatR;
using PS.MoneyMate.Application.Common.Interfaces.Persistence;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.CQRS.ExchangeRates.Queries.GetAllExchangeRates
{
    public class GetAllExchangeRatesHandler : IRequestHandler<GetAllExchangeRatesQuery, IEnumerable<ExchangeRate>>
    {
        private readonly IExchangeRateRepository _repository;

        public GetAllExchangeRatesHandler(IExchangeRateRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ExchangeRate>> Handle(GetAllExchangeRatesQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync();
        }
    }
}
