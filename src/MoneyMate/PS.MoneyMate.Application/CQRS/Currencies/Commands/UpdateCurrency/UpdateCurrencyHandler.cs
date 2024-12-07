using Mapster;
using MediatR;
using PS.MoneyMate.Application.Common.Interfaces.Persistence;

namespace PS.MoneyMate.Application.CQRS.Currencies.Commands.UpdateCurrency
{
    public class UpdateCurrencyHandler : IRequestHandler<UpdateCurrencyCommand, Guid>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public UpdateCurrencyHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<Guid> Handle(UpdateCurrencyCommand request, CancellationToken cancellationToken)
        {
            var existingCurrency = await _currencyRepository.GetByIdAsync(request.Id);
            if (existingCurrency == null)
            {
                throw new KeyNotFoundException($"Currency with Id {request.Id} not found.");
            }

            request.Adapt(existingCurrency);

            await _currencyRepository.UpdateAsync(existingCurrency);

            return request.Id;
        }
    }
}
