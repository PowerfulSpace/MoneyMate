using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Index()
        {
            return View();
        }
    }
}
