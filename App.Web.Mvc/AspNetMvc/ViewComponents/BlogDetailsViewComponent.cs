using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.ViewComponents
{
    public class BlogDetailsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
