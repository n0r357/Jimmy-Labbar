using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_L3_1.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Display(Name = "Name:")]
        [Required(ErrorMessage = "* required")]
        public string Name { get; set; }
        [Display(Name = "E-mail:")]
        [Required(ErrorMessage = "* required")]
        [EmailAddress]
        [CustomAttributes.EmailValidator(new string[] { ".com", ".se", ".nu" })]
        public string Email { get; set; }
    }
}
