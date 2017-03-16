using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_L4.Models
{
    public class CarsCreateVM
    {
        [Display(Name = "Make:")]
        [Required(ErrorMessage = "* required")]
        public string Brand { get; set; }
        [Display(Name = "Doors:")]
        [Required(ErrorMessage = "* required")]
        [Range(3,5, ErrorMessage = "Value must be between 3 and 5.")]
        public int Doors { get; set; }
        [Display(Name = "Top Speed:")]
        [Required(ErrorMessage = "* required")]
        [Range(0, 300, ErrorMessage = "Value must be between 0 and 300.")]
        public int TopSpeed { get; set; }
    }
}
