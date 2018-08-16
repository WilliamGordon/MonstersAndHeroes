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
            Console.WindowHeight = 48;
            Console.CursorVisible = false;

            Game newGame = new Game();
            newGame.Initialisation("Human");
            newGame.SetupBoard();

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.SetCursorPosition(Display.positionBoard[0] + j, Display.positionBoard[1] + i);
                    Console.WriteLine("*");
                }
            }


            for (int i = 10; i < 25; i++)
            {
                for (int j = 10; j < 50; j++)
                {
                    Console.SetCursorPosition(Display.positionBoard[0] + j, Display.positionBoard[1] + i);
                    Console.WriteLine("*");
                }
            }

            while (true)
            {
                newGame.UpDate(Console.ReadKey(true).Key);
            }
        }
    }
}
