using Microsoft.AspNetCore.Mvc;

namespace PS.MoneyMate.Web.Controllers
{
    public class ExchangeRateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
