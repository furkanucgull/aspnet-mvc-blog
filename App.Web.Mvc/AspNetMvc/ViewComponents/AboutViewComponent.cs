using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.ViewComponents
{
    public class AboutViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
