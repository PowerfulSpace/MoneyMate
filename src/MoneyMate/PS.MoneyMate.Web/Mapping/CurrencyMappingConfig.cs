using Mapster;
using PS.MoneyMate.Application.CQRS.Currencies.Commands.CreateCurrency;
using PS.MoneyMate.Application.CQRS.Currencies.Commands.UpdateCurrency;
using PS.MoneyMate.Web.Models.Currency;

namespace PS.MoneyMate.Web.Mapping
{
    public class CurrencyMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CreateCurrencyViewModel, CreateCurrencyCommand>()
                .IgnoreNullValues(true);

            config.NewConfig<UpdateCurrencyViewModel, UpdateCurrencyCommand>()
                .IgnoreNullValues(true);
        }
    }
}
