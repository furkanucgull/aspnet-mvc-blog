using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
