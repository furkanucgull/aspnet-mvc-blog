using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.ViewComponents
{
    public class NavBarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();

        }

    }
}
