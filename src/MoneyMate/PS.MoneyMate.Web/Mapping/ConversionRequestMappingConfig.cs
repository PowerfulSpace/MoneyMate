using Mapster;
using PS.MoneyMate.Application.CQRS.ConversionRequests.Commands.CreateConversionRequest;
using PS.MoneyMate.Application.CQRS.ConversionRequests.Commands.UpdateConversionRequest;
using PS.MoneyMate.Domain.Entities;
using PS.MoneyMate.Web.Models.ConversionRequest;

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

            config.NewConfig<ConversionRequest, ConversionRequestViewModel>()
               .IgnoreNullValues(true);
        }
    }
}
