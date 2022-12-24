using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace UIApp.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError {
                Code = "PasswordTooShort",
                Description = $"Parolanız minimum {length} karakter olmalıdır.!"
            };
        }
    
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = $"Parolalar en az bir alfasayısal olmayan karakter içermelidir."
            };
        }

        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError {
                Code = "PasswordRequiresDigit",
                Description = $"Parolalar en az bir rakamdan ('0'-'9') oluşmalıdır."
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError {
                Code = "PasswordRequiresLower",
                Description = $"Parolalarda en az bir küçük harf ('a'-'z') bulunmalıdır."
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError {
                Code = "PasswordRequiresUpper",
                Description = $"Parolalarda en az bir büyük harf ('A'-'Z') bulunmalıdır."
            };
        }
        public override IdentityError PasswordRequiresUniqueChars(int uniqueChars)
        {
            return new IdentityError {
                Code = "PasswordRequiresUniqueChars",
                Description = $"Şifreler en az {uniqueChars} farklı karakter kullanmalıdır."
            };
        }
    }
}