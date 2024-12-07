using MediatR;

namespace PS.MoneyMate.Application.CQRS.ConversionRequests.Commands.UpdateConversionRequest
{
    public class UpdateConversionRequestCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public Guid FromCurrencyId { get; set; }
        public Guid ToCurrencyId { get; set; }
        public decimal Amount { get; set; }
        public decimal ConvertedAmount { get; set; }
        public DateTime ConversionDate { get; set; }
    }
}
