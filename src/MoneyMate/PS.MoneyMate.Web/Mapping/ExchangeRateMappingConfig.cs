using Mapster;
using PS.MoneyMate.Application.CQRS.ExchangeRates.Commands.CreateExchangeRate;
using PS.MoneyMate.Application.CQRS.ExchangeRates.Commands.UpdateExchangeRate;
using PS.MoneyMate.Domain.Entities;
using PS.MoneyMate.Web.Models.ExchangeRate;

namespace PS.MoneyMate.Web.Mapping
{
    public class ExchangeRateMappingConfig
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CreateExchangeRateViewModel, CreateExchangeRateCommand>()
              .IgnoreNullValues(true);

            config.NewConfig<UpdateExchangeRateViewModel, UpdateExchangeRateCommand>()
                .IgnoreNullValues(true);

            config.NewConfig<ExchangeRate, ExchangeRateViewModel>()
               .IgnoreNullValues(true);
        }
    }
}
