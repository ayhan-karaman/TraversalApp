using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UIApp.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adınızı giriniz!")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Lütfen kullanıcı adınızı giriniz!")]
        public string Password { get; set; }
    }
}