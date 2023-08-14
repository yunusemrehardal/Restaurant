using Microsoft.AspNetCore.Mvc;

namespace Restaurant_PresentationLayer.ViewComponents.Default
{
    public class _FooterPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
