using System.ComponentModel.DataAnnotations;

namespace ECommerce.BLL.ViewModels.AppUserViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Kullanıcı adı boş geçilemez!")]
        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email boş geçilemez!")]
        [EmailAddress(ErrorMessage ="Hatalı email girişi yaptınız!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre(tekrar) boş geçilemez!")]
        [Display(Name = "Şifre(tekrar)")]
        [Compare("Password",ErrorMessage ="Şifreler aynı değil!")]
        public string ConfirmPassword { get; set; }
    }
}
