using DoctorManagement.Models;
using FluentValidation;

namespace DMWebMVC.FluentValidator
{
    public class DMValidator : AbstractValidator<DM>
    {
        public DMValidator()
        {
            RuleFor(Doc=>Doc.Name).Matches("^[a-zA-Z]+$").WithMessage("Name must contain only alphabets.").NotEmpty().WithMessage("Please enter Name");
            RuleFor(Doc => Doc.Speciality).NotEmpty().WithMessage("Please enter Speciality");
            RuleFor(Doc=>Doc.Mobile).Matches(@"^[0-9]{10}$").WithMessage("Mobile number must be 10 digits long.");
            RuleFor(Doc=>Doc.Email).EmailAddress().WithMessage("Invalid email address format.");
        }
    }
}
