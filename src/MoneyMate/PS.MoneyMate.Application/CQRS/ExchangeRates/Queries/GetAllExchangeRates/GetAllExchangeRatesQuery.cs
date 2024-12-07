using MediatR;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.CQRS.ExchangeRates.Queries.GetAllExchangeRates
{
    public class GetAllExchangeRatesQuery : IRequest<IEnumerable<ExchangeRate>>
    {
    }
}
