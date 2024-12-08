using Microsoft.AspNetCore.Mvc;

namespace PS.MoneyMate.Web.Controllers
{
    public class CurrencyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
