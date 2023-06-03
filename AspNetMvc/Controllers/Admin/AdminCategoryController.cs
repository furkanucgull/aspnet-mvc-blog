using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.Controllers.Admin
{
    public class AdminCategoryController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
