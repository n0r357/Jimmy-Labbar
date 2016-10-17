using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2
{
    public class Spider : Arthropod
    {
        public string HasPoison { get; set; }

        public override string Eat()
        {
            return String.Format("{0}\t\t{1}", base.Eat(), HasPoison);
        }
    }
}