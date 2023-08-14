using Microsoft.AspNetCore.Mvc;

namespace Restaurant_PresentationLayer.ViewComponents.Default
{
    public class _NavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
