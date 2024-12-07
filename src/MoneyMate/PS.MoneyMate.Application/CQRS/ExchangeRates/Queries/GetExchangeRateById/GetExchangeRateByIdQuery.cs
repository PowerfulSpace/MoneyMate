using MediatR;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.CQRS.ExchangeRates.Queries.GetExchangeRateById
{
    public class GetExchangeRateByIdQuery : IRequest<ExchangeRate>
    {
        public Guid Id { get; set; }
    }
}
