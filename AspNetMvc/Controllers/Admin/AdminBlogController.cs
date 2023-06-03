using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.Controllers.Admin
{
    public class AdminBlogController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
