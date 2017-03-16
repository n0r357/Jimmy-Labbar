using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_L4.Models
{
    public class CarsIndexVM
    {
        [Display(Name = "Car Brand:")]
        public string Brand { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }
        [Range(250, 300)]
        public bool ShowAsFast { get; set; }

    }
}
