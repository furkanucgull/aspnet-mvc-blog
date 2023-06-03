using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Detail(int id, int page)
        {
            return View();
        }
    }
}
