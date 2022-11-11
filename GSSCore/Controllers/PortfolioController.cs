using Microsoft.AspNetCore.Mvc;

namespace GSSCore.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}