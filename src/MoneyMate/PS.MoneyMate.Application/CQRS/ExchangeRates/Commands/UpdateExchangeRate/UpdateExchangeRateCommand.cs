using MediatR;

namespace PS.MoneyMate.Application.CQRS.ExchangeRates.Commands.UpdateExchangeRate
{
    public class UpdateExchangeRateCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public Guid FromCurrencyId { get; set; }
        public Guid ToCurrencyId { get; set; }
        public decimal Rate { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
