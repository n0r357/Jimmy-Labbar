using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_L5.Models
{
    public class UserLoginVM
    {
        [Display(Name = "User Name:")]
        [Required(ErrorMessage = "* required")]
        public string UserName { get; set; }
        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "* required")]
        public string Password { get; set; }
        [Display(Name = "Accept Cookies")]
        [Range(1, 1, ErrorMessage = "* required")]
        public bool AcceptCookies { get; set; }
    }
}
