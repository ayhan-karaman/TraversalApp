using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidations
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen title kısmını boş bırakmayınız...!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen Açıklma kısmını boş bırakmayınız...!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen minimum 50 karakter giriniz...!");
          
        }
    }
}