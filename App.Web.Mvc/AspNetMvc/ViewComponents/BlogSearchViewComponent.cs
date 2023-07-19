using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.ViewComponents
{
    public class BlogSearchViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();

        }

    }
}
