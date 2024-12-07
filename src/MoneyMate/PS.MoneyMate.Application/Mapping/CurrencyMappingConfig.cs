using Mapster;
using PS.MoneyMate.Application.CQRS.Currencies.Commands.CreateCurrency;
using PS.MoneyMate.Application.CQRS.Currencies.Commands.UpdateCurrency;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.Mapping
{
    public class CurrencyMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CreateCurrencyCommand, Currency>()
                .IgnoreNullValues(true);

            config.NewConfig<UpdateCurrencyCommand, Currency>()
               .IgnoreNullValues(true);
        }
    }
}
