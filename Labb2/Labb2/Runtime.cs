﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    class Runtime
    {
        public void Start()
        {
            Menu animalMenu = new Menu();
            while (!animalMenu.IsProgramOver)
            {
                animalMenu.MainMenu();
            }
        }
    }
}
