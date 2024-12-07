using MediatR;

namespace PS.MoneyMate.Application.CQRS.Currencies.Commands.CreateCurrency
{
    public class CreateCurrencyCommand : IRequest<Guid>
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Symbol { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}
