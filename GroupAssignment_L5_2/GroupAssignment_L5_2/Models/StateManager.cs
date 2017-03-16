using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_L5_2.Models
{
    public class StateManager
    {
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string IsCreated { get; set; }
        public StateManager()
        {
            this.Email = "emailKey";
            this.CompanyName = "nameKey";
            this.IsCreated = "createdKey";
        }
    }
}
