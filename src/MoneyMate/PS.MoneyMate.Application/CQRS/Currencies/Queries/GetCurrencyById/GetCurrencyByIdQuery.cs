using MediatR;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.CQRS.Currencies.Queries.GetCurrencyById
{
    public class GetCurrencyByIdQuery : IRequest<Currency>
    {
        public Guid Id { get; set; }
    }
}
