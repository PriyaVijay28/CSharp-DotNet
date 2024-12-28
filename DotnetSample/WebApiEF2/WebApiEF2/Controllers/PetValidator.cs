using FluentValidation;
using WebApiEF2.Models;

namespace WebApiEF2.Controllers
{
    public class PetValidator : AbstractValidator<PET>
    {
        public PetValidator()
        {
            RuleFor(pet=>pet.PType).NotEmpty().WithMessage("Please mention pet type");
            RuleFor(pet => pet.PName).NotEmpty().WithMessage("Please mention pet name");
        }
    }
}
