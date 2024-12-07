using MediatR;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.CQRS.Currencies.Queries.GetCurrenciesByCode
{
    public class GetCurrencyByCodeQuery : IRequest<Currency>
    {
        public string Code { get; set; } = string.Empty;
    }
}
