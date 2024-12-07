using MediatR;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.CQRS.ConversionRequests.Queries.GetConversionRequestById
{
    public class GetConversionRequestByIdQuery : IRequest<ConversionRequest>
    {
        public Guid Id { get; set; }
    }
}
