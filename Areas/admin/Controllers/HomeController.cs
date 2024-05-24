using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace sbs.Areas.admin.Controllers
{
    [Area("admin")]
    /*[Authorize]*/ 
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
