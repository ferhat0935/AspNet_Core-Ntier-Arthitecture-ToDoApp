using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppNtierCommon.ResponseObjects;

namespace ToDoAppNtierBusiness.Extentions
{
    public static class ValidationResultExtentions
    {
        public static List<CustomValidationError> ConvertToCustomValidationError(this ValidationResult validationResult)
        {
            List<CustomValidationError> errors = new();
            foreach (var error in validationResult.Errors)
            {
                errors.Add(new()
                {
                    ErroMessage = error.ErrorMessage,
                    PropertyName = error.PropertyName
                });
            }
            return errors;  
        }
    }
}
