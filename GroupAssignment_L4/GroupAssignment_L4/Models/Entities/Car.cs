using System;
using System.Collections.Generic;

namespace GroupAssignment_L4.Models.Entities
{
    public partial class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }
        public int? OwnerId { get; set; }

        public virtual Owner Owner { get; set; }
    }
}
