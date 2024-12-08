using Mapster;
using PS.MoneyMate.Application.CQRS.ConversionRequests.Commands.CreateConversionRequest;
using PS.MoneyMate.Application.CQRS.ConversionRequests.Commands.UpdateConversionRequest;
using PS.MoneyMate.Web.Models;

namespace PS.MoneyMate.Web.Mapping
{
    public class ConversionRequestMappingConfig
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CreateConversionRequestViewModel, CreateConversionRequestCommand>()
               .IgnoreNullValues(true);

            config.NewConfig<UpdateConversionRequestViewModel, UpdateConversionRequestCommand>()
                .IgnoreNullValues(true);
        }
    }
}
