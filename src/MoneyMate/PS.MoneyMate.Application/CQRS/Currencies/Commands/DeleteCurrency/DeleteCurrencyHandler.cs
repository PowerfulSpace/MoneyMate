using MediatR;
using PS.MoneyMate.Application.Common.Interfaces.Persistence;

namespace PS.MoneyMate.Application.CQRS.Currencies.Commands.DeleteCurrency
{
    public class DeleteCurrencyHandler : IRequestHandler<DeleteCurrencyCommand, Guid>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public DeleteCurrencyHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<Guid> Handle(DeleteCurrencyCommand request, CancellationToken cancellationToken)
        {
            var currency = await _currencyRepository.GetByIdAsync(request.Id);
            if (currency == null)
            {
                throw new KeyNotFoundException($"Currency with Id {request.Id} not found.");
            }

            await _currencyRepository.DeleteAsync(request.Id);

            return request.Id;
        }
    }
}
