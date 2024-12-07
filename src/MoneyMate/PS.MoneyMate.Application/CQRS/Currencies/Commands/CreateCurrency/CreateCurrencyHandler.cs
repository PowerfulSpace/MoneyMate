using Mapster;
using MediatR;
using PS.MoneyMate.Application.Common.Interfaces.Persistence;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.CQRS.Currencies.Commands.CreateCurrency
{
    public class CreateCurrencyHandler : IRequestHandler<CreateCurrencyCommand, Guid>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public CreateCurrencyHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<Guid> Handle(CreateCurrencyCommand request, CancellationToken cancellationToken)
        {
            var currency = request.Adapt<Currency>();
           
            await _currencyRepository.AddAsync(currency);

            return currency.Id;
        }
    }
}
