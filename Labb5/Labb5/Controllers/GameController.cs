using Labb5.Controllers.Repositories;
using Labb5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5.Controllers
{
    class GameController
    {
        private IRepository gameRepository = new ListRepository();

        public void NewGame()
        {
            var newGame = UI.AddGame();
            gameRepository.AddGame(newGame);
        }

        public void RemoveGame()
        {
            bool loop = true;

            while (loop)
            {
                try
                {
                    var games = PrintGameList();
                    var index = UI.ReturnChoice(games.Count()) - 1;
                    if (index < games.Count())
                    {
                        gameRepository.RemoveGame(games[index]);
                        UI.ItemRemoved();
                        loop = false;
                    }
                    else if (games.Count() == 0)
                    {
                        loop = false;
                    }
                }
                catch (Exception)
                {
                    loop = true;
                }
            }
        }

        public void EditGame()
        {
            bool loop = true;

            while (loop)
            {
                try
                {
                    var games = PrintGameList();
                    var index = UI.ReturnChoice(games.Count()) - 1;
                    if (index < games.Count())
                    {
                        UI.EditItem(games[index]);
                        loop = false;
                    }
                    else
                    {
                        UI.InvalidChoice();
                    }
                }
                catch (Exception)
                {
                    loop = true;
                }
            }
            UI.ItemEdited();
        }

        public Item[] PrintGameList()
        {
            UI.PrintGenreMenuBar();
            var games = gameRepository.GetGameList();
            foreach (var game in games)
            {
                Console.WriteLine(UI.StringFormat(), Array.IndexOf(games, game) + 1, game.Title, game.Genre, game.Price);
            }
            return games;
        }
    }
}
