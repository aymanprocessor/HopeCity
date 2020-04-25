using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeCity.Validators
{
    public class StudentValidator : AbstractValidator<student>
    {
        public StudentValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;
            RuleFor(s => s.Id).NotEmpty().WithMessage("Enter National ID").Length(14).WithMessage("National ID Must Be 14 Number"); ;
            RuleFor(s => s.name).NotEmpty().WithMessage("Enter Name");
            RuleFor(s => s.dob).NotEmpty().WithMessage("Enter Date Of Birth");
            RuleFor(s => s.gender).NotEmpty().NotNull().WithMessage("Enter Gender");
            RuleFor(s => s.nat).NotEmpty().WithMessage("Enter National");
        }
    }
}