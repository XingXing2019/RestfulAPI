﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Routine.Api.Models;

namespace Routine.Api.ValidationAttributes
{
    public class EmployeeNoMustDifferentFromFirstNameAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var addDto = (EmployeeAddEditDto) validationContext.ObjectInstance;
            if (addDto.EmployeeNo == addDto.FirstName)
                return new ValidationResult(ErrorMessage, new []{nameof(EmployeeAddEditDto) });
            return ValidationResult.Success;
        }
    }
}
