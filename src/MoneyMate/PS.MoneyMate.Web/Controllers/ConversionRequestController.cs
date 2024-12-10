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

        // GET: /ConversionRequest/Details/{id}
        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var conversionRequest = await _mediator.Send(new GetConversionRequestByIdQuery { Id = id });
            if (conversionRequest == null)
                return NotFound();

            var viewModel = conversionRequest.Adapt<ConversionRequestViewModel>();
            return View(viewModel);
        }

        // GET: /ConversionRequest/Create
        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new CreateConversionRequestViewModel();
            return View(viewModel);
        }

        // POST: /ConversionRequest/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateConversionRequestViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var command = model.Adapt<CreateConversionRequestCommand>();
            var conversionRequestId = await _mediator.Send(command);
            return RedirectToAction(nameof(Details), new { id = conversionRequestId });
        }

        // GET: /ConversionRequest/Edit/{id}
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var conversionRequest = await _mediator.Send(new GetConversionRequestByIdQuery { Id = id });
            if (conversionRequest == null)
                return NotFound();

            var viewModel = conversionRequest.Adapt<UpdateConversionRequestViewModel>();
            return View(viewModel);
        }

        // POST: /ConversionRequest/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UpdateConversionRequestViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var command = model.Adapt<UpdateConversionRequestCommand>();
            await _mediator.Send(command);
            return RedirectToAction(nameof(Details), new { id = model.Id });
        }

        // POST: /ConversionRequest/Delete/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _mediator.Send(new DeleteConversionRequestCommand { Id = id });
            return RedirectToAction(nameof(Index));
        }
    }
}
