using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles ="Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
