using Microsoft.AspNetCore.Mvc;

namespace Restaurant_PresentationLayer.ViewComponents.Default
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
