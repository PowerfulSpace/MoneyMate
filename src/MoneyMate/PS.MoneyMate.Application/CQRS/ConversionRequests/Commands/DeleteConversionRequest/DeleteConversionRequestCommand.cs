using MediatR;

namespace PS.MoneyMate.Application.CQRS.ConversionRequests.Commands.DeleteConversionRequest
{
    public class DeleteConversionRequestCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
    }
}
