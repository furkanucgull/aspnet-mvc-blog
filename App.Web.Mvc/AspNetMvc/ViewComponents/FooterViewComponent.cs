using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
