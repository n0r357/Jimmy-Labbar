using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_L3_1.Models
{
    public class PeopleCreateVM
    {
        public int Id { get; set; }
        [Display(Name = "Name:")]
        [Required(ErrorMessage = "* required")]
        public string Name { get; set; }
        [Display(Name = "E-mail:")]
        [Required(ErrorMessage = "* required")]
        [EmailAddress]
        [CustomAttributes.EmailValidator(new string[] { ".com", ".se", ".nu" }, ErrorMessage = "Invalid format, must end with .com, .se or .nu.")]
        public string Email { get; set; }
        [Range(1, 1, ErrorMessage = "* Must accept terms.")]
        [Required]
        public bool AcceptTerms { get; set; }
    }
}
