using Labb7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7.Interface
{
    interface ISellable
    {
        string ProductInformation { get; set; }
        string Category { get; set; }
        double Price { get; set; }
        string GetCategory();
    }
}
