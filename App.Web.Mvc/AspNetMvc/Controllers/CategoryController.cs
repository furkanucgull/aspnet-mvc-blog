using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Travel(int id, int page)
        {
            return View();
        }
        public IActionResult Weekends(int id, int page)
        {
            return View();
        }
        public IActionResult Lifestyle(int id, int page)
        {
            return View();
        }
        public IActionResult Explore(int id, int page)
        {
            return View();
        }
    }
}
