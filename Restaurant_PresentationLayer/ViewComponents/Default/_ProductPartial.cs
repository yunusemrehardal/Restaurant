using Microsoft.AspNetCore.Mvc;
using Restaurant_BusinessLayer.Abstract;

namespace Restaurant_PresentationLayer.ViewComponents.Default
{
    public class _ProductPartial : ViewComponent
    {
        private readonly IProductService _productService;

        public _ProductPartial(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _productService.TGetList();
            return View(values);
        }
    }
}
