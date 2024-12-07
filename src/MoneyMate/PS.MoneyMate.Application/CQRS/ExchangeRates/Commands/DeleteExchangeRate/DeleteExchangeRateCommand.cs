using MediatR;

namespace PS.MoneyMate.Application.CQRS.ExchangeRates.Commands.DeleteExchangeRate
{
    public class DeleteExchangeRateCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
    }
}
