using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2
{
    public class Fish : Animal
    {
        public string HaveLungs { get; set; }

        public override string General()
        {
            return String.Format("{0}\t{1}", base.General(), HaveLungs);
        }
    }
}