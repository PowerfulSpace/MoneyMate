using MediatR;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.CQRS.ExchangeRates.Queries.GetExchangeRateByCurrencyPair
{
    public class GetExchangeRateByCurrencyPairQuery : IRequest<ExchangeRate>
    {
        public Guid FromCurrencyId { get; set; }
        public Guid ToCurrencyId { get; set; }
    }
}
