using Mapster;
using PS.MoneyMate.Application.CQRS.ExchangeRates.Commands.CreateExchangeRate;
using PS.MoneyMate.Application.CQRS.ExchangeRates.Commands.UpdateExchangeRate;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.Mapping
{
    public class ExchangeRateMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CreateExchangeRateCommand, ExchangeRate>()
               .IgnoreNullValues(true);

            config.NewConfig<UpdateExchangeRateCommand, ExchangeRate>()
               .IgnoreNullValues(true);
        }
    }
}
