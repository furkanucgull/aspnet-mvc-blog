using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.ViewComponents
{
    public class ArticleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();

        }

    }
}
