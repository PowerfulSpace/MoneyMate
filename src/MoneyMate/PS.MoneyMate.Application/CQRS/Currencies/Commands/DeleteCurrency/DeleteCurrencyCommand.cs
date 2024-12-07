using MediatR;

namespace PS.MoneyMate.Application.CQRS.Currencies.Commands.DeleteCurrency
{
    public class DeleteCurrencyCommand : IRequest<Guid>
    {
        public Guid Id{ get; set; }
    }
}
