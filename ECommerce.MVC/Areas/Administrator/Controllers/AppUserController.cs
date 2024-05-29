using ECommerce.BLL.ViewModels.AppUserViewModels;
using ECommerce.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Areas.Administrator.Controllers
{
    public class AppUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public AppUserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            //veritabanında kayıtlı olan kullanıcılar liste halinde View'da listelenecekler.
            var users = _userManager.Users.Select(x => new AppUserListViewModel
            {
                ID = x.Id.ToString(),
                Gender = x.Gender,
                BirthDate = x.BirthDate,
                EmailConfirmed = x.EmailConfirmed,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber,
                Username = x.UserName,
                Address = x.Address
            }).ToList();
            return View(users);
        }

        public IActionResult Details(string id)
        {
            //Kullanıcı detayı tek bir sayfada gösterilecek.
            return View();
        }

        public IActionResult AddToRole(string id, string roleName)
        {
            return View();
        }

        public IActionResult ForgotPassword(int id)
        {
            return View();
        }

        public async Task<IActionResult> Update(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                AppUserListViewModel appUserVM = new AppUserListViewModel
                {
                    ID = user.Id.ToString(),
                    Gender = user.Gender,
                    BirthDate = user.BirthDate,
                    EmailConfirmed = user.EmailConfirmed,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    Username = user.UserName,
                    Address = user.Address
                };

                return View(appUserVM);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update(AppUserListViewModel appUserVM)
        {
            return View();
        }

        public IActionResult DeleteUser(string id)
        {
            return View();
        }
    }
}
