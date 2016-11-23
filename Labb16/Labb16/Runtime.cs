using Labb16.Models;
using Labb16.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb16
{
    class Runtime
    {
        public void Start()
        {
            bool loop = true;
            var list = new ListProductRepository();
            var file = new FileProductRepository();
            file.FileDirectory = Environment.CurrentDirectory;
            file.FilePath = String.Format("{0}{1}", file.FileDirectory, "\\data.json");

            if (!Directory.Exists(file.FileDirectory))
            {
                Directory.CreateDirectory(file.FileDirectory);
            }

            if (!File.Exists(file.FilePath))
            {
                File.Create(file.FilePath);
                string jsonString = JsonConvert.SerializeObject(list.GetAll());
                Console.WriteLine(jsonString);
                File.WriteAllText(file.FilePath, jsonString);
            }

            while (loop)
            {
                switch (UI.MainMenu())
                {
                    case ConsoleKey.D1: //  Show list
                        UI.PrintList(list.GetAll());
                        UI.PressAnyKeyToContinue();
                        break;
                    case ConsoleKey.D2: //  Add item to list
                        list.Add();
                        UI.PressAnyKeyToContinue();
                        break;
                    case ConsoleKey.D3: //  Edit item in list
                        int choice = UI.GetItem(list.GetAll());
                        UI.PrintList(list.Get(choice));
                        list.Delete(choice);
                        list.Add();
                        UI.PressAnyKeyToContinue();
                        break;
                    case ConsoleKey.D4: //  Remove item from
                        UI.PrintList(list.GetAll());
                        choice = UI.GetItem(list.GetAll());
                        list.Delete(choice);
                        UI.PressAnyKeyToContinue();
                        break;
                    case ConsoleKey.D5: //  Show list from file
                        UI.PrintList(file.GetAll());
                        UI.PressAnyKeyToContinue();
                        break;
                    case ConsoleKey.D6: //  Add item to file list
                        file.Add();
                        UI.PressAnyKeyToContinue();
                        break;
                    case ConsoleKey.D7: //  Edit item in file list
                        choice = UI.GetItem(file.GetAll());
                        UI.PrintList(file.Get(choice));
                        file.Delete(choice);
                        file.Add();
                        UI.PressAnyKeyToContinue();
                        break;
                    case ConsoleKey.D8: //  Remove item from file list
                        UI.PrintList(file.GetAll());
                        choice = UI.GetItem(file.GetAll());
                        file.Delete(choice);
                        UI.PressAnyKeyToContinue();
                        break;
                    case ConsoleKey.D9:
                        loop = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
