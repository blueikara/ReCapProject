using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.Description).MinimumLength(2).NotEmpty();

            RuleFor(p => p.DailyPrice).NotEmpty().GreaterThan(0);

            RuleFor(p => p.ModelYear).NotEmpty().GreaterThan(2000);

        }
    }
}
