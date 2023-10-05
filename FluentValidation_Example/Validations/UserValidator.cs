using FluentValidation;
namespace FluentValidation_Example.Validations;

public class UserValidator : AbstractValidator<User>
{
    public UserValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name cannot be empty");
        RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name cannot be empty");
        RuleFor(x => x.Email).NotEmpty().WithMessage("Email cannot be empty");
        RuleFor(x => x.Email).EmailAddress().WithMessage("Email is not valid");
        RuleFor(x => x.Age).NotEmpty().WithMessage("Age cannot be empty");
        RuleFor(x => x.Age).InclusiveBetween(18, 65).WithMessage("Age must be between 18 and 65");
        RuleFor(x => x.Password).NotEmpty().WithMessage("Password cannot be empty");
        RuleFor(x => x.Password).MinimumLength(5).WithMessage("Password cannot be less than 5 characters");
        RuleFor(x => x.Password).MaximumLength(100).WithMessage("Password cannot be more than 100 characters");
        
    }
}