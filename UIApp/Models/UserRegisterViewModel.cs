using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UIApp.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen adınızı giriniz!")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Lütfen soyadınızı giriniz!")]
        public string SurName { get; set; }

        [Required(ErrorMessage ="Lütfen kullanıcı adınızı giriniz!")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Lütfen e-posta adresi giriniz!")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Lütfen şifrenizi giriniz!")]
        [Compare("ConfirmPassword",ErrorMessage ="Lütfen şifrenizi kotrol ediniz!")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Lütfen şifrenizi tekrar giriniz!")]
        [Compare("Password",ErrorMessage ="Lütfen şifrenizi kotrol ediniz!")]
        public string ConfirmPassword { get; set; }
    }
}