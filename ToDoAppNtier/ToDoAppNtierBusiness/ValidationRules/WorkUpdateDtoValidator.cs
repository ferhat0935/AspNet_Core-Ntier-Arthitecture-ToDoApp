using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppNtierDtos.WorkDtos;

namespace ToDoAppNtierBusiness.ValidationRules
{
    public class WorkUpdateDtoValidator:AbstractValidator<WorkUpdateDto>
    {
        public WorkUpdateDtoValidator()
        {
           RuleFor(x=>x.Id).NotEmpty();
            RuleFor(x=>x.Definition).NotEmpty();
        }
    }
}
