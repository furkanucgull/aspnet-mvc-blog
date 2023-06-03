using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.Controllers.Admin
{
    public class AdminPageController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
