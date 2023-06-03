using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.Controllers.Admin
{
    public class AdminSettingController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
