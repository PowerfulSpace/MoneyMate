using Mapster;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PS.MoneyMate.Application.CQRS.Currencies.Commands.CreateCurrency;
using PS.MoneyMate.Application.CQRS.Currencies.Commands.DeleteCurrency;
using PS.MoneyMate.Application.CQRS.Currencies.Commands.UpdateCurrency;
using PS.MoneyMate.Application.CQRS.Currencies.Queries.GetAllCurrencies;
using PS.MoneyMate.Application.CQRS.Currencies.Queries.GetCurrencyById;
using PS.MoneyMate.Web.Models.Currency;

namespace PS.MoneyMate.Web.Controllers
{
    public class CurrencyController : Controller
    {
        private readonly ISender _mediator;
        private readonly IMapper _mapper;

        public CurrencyController(ISender mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        // GET: /Currency
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var currencies = await _mediator.Send(new GetAllCurrenciesQuery());
            var viewModel = currencies.Adapt<IEnumerable<CurrencyViewModel>>();
            return View(viewModel);
        }

        // GET: /Currency/Details/{id}
        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var currency = await _mediator.Send(new GetCurrencyByIdQuery { Id = id });
            if (currency == null)
                return NotFound();

            var viewModel = currency.Adapt<CurrencyViewModel>();
            return View(viewModel);
        }

        // GET: /Currency/Create
        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new CreateCurrencyViewModel();
            return View(viewModel);
        }

        // POST: /Currency/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateCurrencyViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var command = model.Adapt<CreateCurrencyCommand>();
            var currencyId = await _mediator.Send(command);
            return RedirectToAction(nameof(Details), new { id = currencyId });
        }

        // GET: /Currency/Edit/{id}
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var currency = await _mediator.Send(new GetCurrencyByIdQuery { Id = id });
            if (currency == null)
                return NotFound();

            var viewModel = currency.Adapt<UpdateCurrencyViewModel>();
            return View(viewModel);
        }

        // POST: /Currency/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UpdateCurrencyViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var command = model.Adapt<UpdateCurrencyCommand>();
            await _mediator.Send(command);
            return RedirectToAction(nameof(Details), new { id = model.Id });
        }

        // POST: /Currency/Delete/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _mediator.Send(new DeleteCurrencyCommand { Id = id });
            return RedirectToAction(nameof(Index));
        }
    }
}
