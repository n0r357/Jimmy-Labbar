using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_L5_2.Models
{
    public class CreateVM
    {
        [Display(Name = "Support E-mail:")]
        [Required(ErrorMessage = "* required")]
        public string Email { get; set; }
        [Display(Name = "Company Name:")]
        [Required(ErrorMessage = "* required")]
        public string CompanyName { get; set; }
    }
}
