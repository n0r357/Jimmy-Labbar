using Labb15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15.Classes
{
    class Car : IVehicle , IPushable
    {
        public void Lock()
        {
            UI.LockVehicle(this.GetType().Name);
        }

        public void Push()
        {
            UI.PushObject(this.GetType().Name);
        }

        public void Start()
        {
            UI.StartVehicle(this.GetType().Name);
        }

        public void Stop()
        {
            UI.StopVehicle(this.GetType().Name);
        }

        public void Unlock()
        {
            UI.UnlockVehicle(this.GetType().Name);
        }
    }
}
