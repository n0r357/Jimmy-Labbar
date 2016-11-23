using Labb15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15.Classes
{
    class Boulder : IPushable
    {
        public void Push()
        {
            UI.PushObject(this.GetType().Name);
        }
    }
}
