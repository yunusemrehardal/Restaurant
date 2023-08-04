using Microsoft.AspNetCore.Mvc;

namespace Restaurant_PresentationLayer.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
