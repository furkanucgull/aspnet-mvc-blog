using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Search(string query, int id)
        {
            return View();
        }
        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
