using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index(int id, int page)
        {
            return View();
        }
    }
}
