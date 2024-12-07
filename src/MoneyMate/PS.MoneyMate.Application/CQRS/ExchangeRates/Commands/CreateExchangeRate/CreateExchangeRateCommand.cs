using MediatR;

namespace PS.MoneyMate.Application.CQRS.ExchangeRates.Commands.CreateExchangeRate
{
    public class CreateExchangeRateCommand : IRequest<Guid>
    {
        public Guid FromCurrencyId { get; set; }
        public Guid ToCurrencyId { get; set; }
        public decimal Rate { get; set; }
    }
}
