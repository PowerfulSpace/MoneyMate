using Mapster;
using PS.MoneyMate.Application.CQRS.ConversionRequests.Commands.CreateConversionRequest;
using PS.MoneyMate.Application.CQRS.ConversionRequests.Commands.UpdateConversionRequest;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.Mapping
{
    public class ConversionRequestMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CreateConversionRequestCommand, ConversionRequest>()
               .IgnoreNullValues(true);

            config.NewConfig<UpdateConversionRequestCommand, ConversionRequest>()
               .IgnoreNullValues(true);
        }
    }
}
