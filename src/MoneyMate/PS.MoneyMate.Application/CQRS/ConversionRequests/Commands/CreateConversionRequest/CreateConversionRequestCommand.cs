using MediatR;

namespace PS.MoneyMate.Application.CQRS.ConversionRequests.Commands.CreateConversionRequest
{
    public class CreateConversionRequestCommand : IRequest<Guid>
    {
        public Guid FromCurrencyId { get; set; }
        public Guid ToCurrencyId { get; set; }
        public decimal Amount { get; set; }
        public decimal ConvertedAmount { get; set; }
        public DateTime ConversionDate { get; set; } = DateTime.UtcNow;
    }
}
