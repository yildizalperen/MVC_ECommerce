using ECommerce.BLL.ViewModels.AppUserViewModels;
using ECommerce.Common.EmailHelpers;
using ECommerce.Models.Entities;
using ECommerce.MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web;

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
                    var emailToken =  _userManager.GenerateEmailConfirmationTokenAsync(user);

                    var encodeToken = HttpUtility.UrlEncode(emailToken.Result);

                    string confirmationLink = Url.Action("Activation", "Home", new { id = user.Id, token = encodeToken},Request.Scheme);

                    string body = $"Merhaba {registerVM.Username} aramıza Hoşgeldiniz! İgili linke tıklayarak hesabınızı aktif hale getirebilirsiniz. {confirmationLink}";



                    //Todo: Konfirmasyon maili gönderilecek.
                    EmailSender.SendEmail(registerVM.Email, "Aktivasyon", body);

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

        [HttpGet]
        public async Task<IActionResult> Activation(string id, string token)
        {
            if (id!=null && token!=null)
            {
                var existUser = await _userManager.FindByIdAsync(id);

                if (existUser != null)
                {
                    var result = await _userManager.ConfirmEmailAsync(existUser,token);
                    if (result.Succeeded)
                    {
                        TempData["Success"] = "hesabınız aktif hale getirildi.";
                        return RedirectToAction("Index");
                    }
                }
            }
            //kullanıcı konfirmasyon işlemi
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
