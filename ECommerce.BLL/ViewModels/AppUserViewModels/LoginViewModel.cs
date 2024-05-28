using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.ViewModels.AppUserViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email boş geçilemez!")]
        [EmailAddress(ErrorMessage = "Hatalı email girişi yaptınız!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        public bool Remember { get; set; }
    }
}
