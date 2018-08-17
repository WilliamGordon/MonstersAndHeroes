using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAndHeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONSOLE SETTINGS
            Console.WindowWidth = 130;
            Console.WindowHeight = 53;
            Console.CursorVisible = false;

            Game newGame = new Game();
            newGame.Initialisation("Human");
            newGame.SetupBoard();

            while (true)
            {
                newGame.UpDate(Console.ReadKey(true).Key);
            }
        }
    }
}
