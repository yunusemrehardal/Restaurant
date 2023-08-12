using Microsoft.AspNetCore.Mvc;
using Restaurant_BusinessLayer.Abstract;

namespace Restaurant_PresentationLayer.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IContactService _contactService;

        public CustomerController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.TGetList();
            return View(values);
        }
    }
}
