using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Routine.Api.Entities;
using Routine.Api.ValidationAttributes;

namespace Routine.Api.Models
{
    [EmployeeNoMustDifferentFromFirstName(ErrorMessage = "Employee Number Cannot be Same as First Name")]
    public class EmployeeAddDto : IValidatableObject
    {
        [Display(Name = "Employee Number")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Length of {0} is {1}")]
        public string EmployeeNo { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Display(Name = "Gender")]
        public Gender Gender { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (FirstName == LastName)
            {
                yield return new ValidationResult("First Name and Last Name cannot be same", new []{nameof(FirstName), nameof(LastName)});
            }
        }
    }
}
