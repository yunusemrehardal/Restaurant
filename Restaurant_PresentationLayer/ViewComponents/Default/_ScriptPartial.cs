using Microsoft.AspNetCore.Mvc;

namespace Restaurant_PresentationLayer.ViewComponents.Default
{
    public class _ScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
