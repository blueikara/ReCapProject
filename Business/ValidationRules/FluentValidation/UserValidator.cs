using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator: AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.Email).NotEmpty().EmailAddress();

            RuleFor(p => p.FirstName).NotEmpty().MaximumLength(20);

            RuleFor(p => p.LastName).NotEmpty().MaximumLength(10);

            RuleFor(p => p.Password).NotEmpty().Length(1, 6);
            
        }
    }
}
