using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.Controllers.Admin
{
    public abstract class AdminBaseController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
