using Mapster;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PS.MoneyMate.Application.CQRS.ExchangeRates.Commands.CreateExchangeRate;
using PS.MoneyMate.Application.CQRS.ExchangeRates.Commands.DeleteExchangeRate;
using PS.MoneyMate.Application.CQRS.ExchangeRates.Commands.UpdateExchangeRate;
using PS.MoneyMate.Application.CQRS.ExchangeRates.Queries.GetAllExchangeRates;
using PS.MoneyMate.Application.CQRS.ExchangeRates.Queries.GetExchangeRateById;
using PS.MoneyMate.Web.Models.ExchangeRate;

namespace PS.MoneyMate.Web.Controllers
{
    public class ExchangeRateController : Controller
    {
        private readonly ISender _mediator;
        private readonly IMapper _mapper;

        public ExchangeRateController(ISender mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        // GET: /ExchangeRate
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var exchangeRates = await _mediator.Send(new GetAllExchangeRatesQuery());
            var viewModel = exchangeRates.Adapt<IEnumerable<ExchangeRateViewModel>>();
            return View(viewModel);
        }

       
    }
}