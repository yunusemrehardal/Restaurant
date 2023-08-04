using Microsoft.AspNetCore.Mvc;
using Restaurant_BusinessLayer.Abstract;
using Restaurant_EntityLayer.Concrete;

namespace Restaurant_PresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.TGetList();
            return View(values);
        }

        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult GetContact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetContact(Contact contact)
        {
            contact.SendDateMessage = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            _contactService.TInsert(contact);
            return RedirectToAction("Index", "Default");
        }
    }
}
