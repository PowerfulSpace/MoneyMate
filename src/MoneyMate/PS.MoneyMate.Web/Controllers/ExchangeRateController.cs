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

        // GET: /ExchangeRate/Details/{id}
        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var exchangeRate = await _mediator.Send(new GetExchangeRateByIdQuery { Id = id });
            if (exchangeRate == null)
                return NotFound();

            var viewModel = exchangeRate.Adapt<ExchangeRateViewModel>();
            return View(viewModel);
        }

        // GET: /ExchangeRate/Create
        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new CreateExchangeRateViewModel();
            return View(viewModel);
        }

        // POST: /ExchangeRate/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateExchangeRateViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var command = model.Adapt<CreateExchangeRateCommand>();
            var exchangeRateId = await _mediator.Send(command);
            return RedirectToAction(nameof(Details), new { id = exchangeRateId });
        }

        // GET: /ExchangeRate/Edit/{id}
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var exchangeRate = await _mediator.Send(new GetExchangeRateByIdQuery { Id = id });
            if (exchangeRate == null)
                return NotFound();

            var viewModel = exchangeRate.Adapt<UpdateExchangeRateViewModel>();
            return View(viewModel);
        }

        // POST: /ExchangeRate/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UpdateExchangeRateViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var command = model.Adapt<UpdateExchangeRateCommand>();
            await _mediator.Send(command);
            return RedirectToAction(nameof(Details), new { id = model.Id });
        }

        // POST: /ExchangeRate/Delete/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _mediator.Send(new DeleteExchangeRateCommand { Id = id });
            return RedirectToAction(nameof(Index));
        }
    }
}