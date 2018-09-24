using DatingApp.API.Models;
using FluentValidation;

namespace DatingApp.API.Validations
{
    public class ValueValidations:AbstractValidator<Value>
    {
        public ValueValidations(){
            RuleFor(x=>x.Name).NotEmpty()
            .WithMessage("Value(name) is required");
            RuleFor(x => x.Name).Length(1,60)
            .WithMessage("Value(name) shoud be between 1 and 60 characters long");
            


        }
    }
}