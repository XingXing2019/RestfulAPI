using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Routine.Api.Models
{
    public class CompanyAddDto
    {
        [Required(ErrorMessage = "{0} is required")]
        [MaxLength(100)]
        [Display(Name = "Company Name")]
        public string Name { get; set; }

        [MaxLength(500)]
        [Display(Name = "Company Introduction")]
        public string Introduction { get; set; }
        public ICollection<EmployeeAddDto> Employees { get; set; } = new List<EmployeeAddDto>();
    }
}
