using Microsoft.AspNetCore.Mvc;
using Restaurant_BusinessLayer.Abstract;

namespace Restaurant_PresentationLayer.ViewComponents.Default
{
    public class _TestimonialPartial : ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public _TestimonialPartial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _testimonialService.TGetList();
            return View(values);
        }
    }
}
