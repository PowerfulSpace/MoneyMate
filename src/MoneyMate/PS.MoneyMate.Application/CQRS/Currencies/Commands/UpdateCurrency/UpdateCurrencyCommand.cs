using MediatR;

namespace PS.MoneyMate.Application.CQRS.Currencies.Commands.UpdateCurrency
{
    public class UpdateCurrencyCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Symbol { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}
