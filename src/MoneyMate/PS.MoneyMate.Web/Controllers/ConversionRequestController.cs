using Mapster;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PS.MoneyMate.Application.CQRS.ConversionRequests.Commands.CreateConversionRequest;
using PS.MoneyMate.Application.CQRS.ConversionRequests.Commands.DeleteConversionRequest;
using PS.MoneyMate.Application.CQRS.ConversionRequests.Commands.UpdateConversionRequest;
using PS.MoneyMate.Application.CQRS.ConversionRequests.Queries.GetAllConversionRequests;
using PS.MoneyMate.Application.CQRS.ConversionRequests.Queries.GetConversionRequestById;
using PS.MoneyMate.Web.Models.ConversionRequest;

namespace PS.MoneyMate.Web.Controllers
{
    public class ConversionRequestController : Controller
    {
        private readonly ISender _mediator;
        private readonly IMapper _mapper;

        public ConversionRequestController(ISender mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        // GET: /ConversionRequest
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var conversionRequests = await _mediator.Send(new GetAllConversionRequestsQuery());
            var viewModel = conversionRequests.Adapt<IEnumerable<ConversionRequestViewModel>>();
            return View(viewModel);
        }

      
    }
}
