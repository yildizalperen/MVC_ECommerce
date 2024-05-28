using ECommerce.BLL.ViewModels.AppUserViewModels;
using ECommerce.Models.Entities;
using ECommerce.MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ECommerce.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerVM)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                    Email = registerVM.Email,
                    UserName = registerVM.Username,
                };

               var result = await _userManager.CreateAsync(user,registerVM.ConfirmPassword);

                if (result.Succeeded)
                {
                    //Todo: Konfirmasyon maili gönderilecek.

                    TempData["Success"] = $"{registerVM.Email} adresine aktivasyon maili gönderilmiştir. Kaydınızı tamamlayınız!";
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View(registerVM);
            }
            
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel loginVM)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            return View();
        }



























        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
