using Microsoft.AspNetCore.Mvc;

namespace Restaurant_PresentationLayer.ViewComponents.Default
{
    public class _FeaturePartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.title1 = "Hergün FastFOOD Yiyin!";
            ViewBag.title2 = "Sevdiğiniz Yemekleri Paylaşın!";
            return View();
        }
    }
}
