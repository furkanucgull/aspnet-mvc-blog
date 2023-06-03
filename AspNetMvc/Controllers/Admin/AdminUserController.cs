using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.Controllers.Admin
{
    public class AdminUserController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
