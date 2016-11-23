using Labb15.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15
{
    class Runtime
    {
        public void Start()
        {
            bool loop = true;
            var bike = new Bicycle();
            var car = new Car();
            var spaceship = new Spaceship();
            var boulder = new Boulder();
            var button = new Button();

            while (loop)
            {
                switch (UI.MainMenu())
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        bike.Unlock();
                        bike.Start();
                        bike.Stop();
                        bike.Lock();
                        bike.Push();
                        UI.PressAnyKeyToContinue();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        boulder.Push();
                        UI.PressAnyKeyToContinue();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        button.Push();
                        UI.PressAnyKeyToContinue();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        car.Unlock();
                        car.Start();
                        car.Stop();
                        car.Lock();
                        car.Push();
                        UI.PressAnyKeyToContinue();
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        spaceship.Unlock();
                        spaceship.Start();
                        spaceship.Stop();
                        spaceship.Lock();
                        UI.PressAnyKeyToContinue();
                        break;
                    case ConsoleKey.D6:
                        loop = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
