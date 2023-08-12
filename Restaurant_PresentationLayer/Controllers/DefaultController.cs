using Microsoft.AspNetCore.Mvc;

namespace Restaurant_PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
