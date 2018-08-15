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

            Human wil = new Human();
            Random newRand = new Random();
            Coordinate firstCoordinate = new Coordinate(newRand.Next(-2, 2), newRand.Next(-2, 2));

            //DICTIONNARY: (Key)MONSTER - (Value)COORDINATE
            Dictionary<Monster, Coordinate> monsterCoordinate = new Dictionary<Monster, Coordinate>();

            //CREATE FIRST MONSTER
            monsterCoordinate.Add(new Dragon(), new Coordinate(newRand.Next(1, 15), newRand.Next(1, 15)));

            //CREATE NINE OTHER MONSTER WITH DIFFRENT COORDINATE
            int tempX = 0;
            int tempY = 0;

            for (int k = 0; k < 80;)
            {
                //COORDINATE NEW MONSTER
                tempX = newRand.Next(1, Display.boardDimension[0]);
                tempY = newRand.Next(1, Display.boardDimension[1]);
                bool goodCoordinate = true;

                //LOOP TROUGH COORDINATE OF THE OTHER MONSTER TO CHECK IF COORDINATE OF NEW MONSTER ARE VALID
                foreach (KeyValuePair<Monster, Coordinate> monster in monsterCoordinate)
                {
                    //CHECK PATTERN
                    for (int i = monster.Value.y - 2; i <= monster.Value.y + 2; i++)           // Y COORDINATE
                    {
                        for (int j = monster.Value.x - 2; j <= monster.Value.x + 2; j++)       // X COORDINATE
                        {

                            if ((j == monster.Value.x || i == monster.Value.y)
                                ||
                               ((j < monster.Value.x + 2) && (j > monster.Value.x - 2)) && ((i < monster.Value.y + 2) && (i > monster.Value.y - 2)))
                            {
                                if (j == tempX && i == tempY)
                                {
                                    goodCoordinate = false;
                                }
                            }
                        }
                    }
                }

                if (goodCoordinate)
                {
                    switch (newRand.Next(1, 4))
                    {
                        case 1:
                            monsterCoordinate.Add(new Dragon(), new Coordinate(tempX, tempY));
                            break;
                        case 2:
                            monsterCoordinate.Add(new Wolf(), new Coordinate(tempX, tempY));
                            break;
                        case 3:
                            monsterCoordinate.Add(new Orc(), new Coordinate(tempX, tempY));
                            break;
                    }
                    k++;
                }
            }

            //PRINT BOARD
            Display.MainContainer();
            Display.Title();
            Display.Board();
            Display.CharacterStat(wil);
            //Display.CombatBoard();
            Display.MonsterStatArea();
            Display.HeroStatArea();

            //HERO NAVIGATION
            Coordinate PositionHero = new Coordinate(1, 1);
            ConsoleKey key = new ConsoleKey();

            while (true)
            {
                Console.SetCursorPosition(PositionHero.x + Display.positionBoard[0], PositionHero.y + Display.positionBoard[1]);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("H");
                Console.ResetColor();
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (PositionHero.x > 1)
                        {
                            if(PositionHero.x == Display.boardDimension[0] - 1)
                            {
                                Console.SetCursorPosition(PositionHero.x + Display.positionBoard[0] + 1, PositionHero.y + Display.positionBoard[1]);
                                Console.Write("║");
                            }
                            Console.SetCursorPosition(PositionHero.x + Display.positionBoard[0], PositionHero.y + Display.positionBoard[1]);
                            Console.Write(" ");
                            PositionHero.x--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (PositionHero.x < Display.boardDimension[0] - 1)
                        {
                            if (PositionHero.x == Display.boardDimension[0] - 1)
                            {
                                Console.SetCursorPosition(PositionHero.x + Display.positionBoard[0] + 1, PositionHero.y + Display.positionBoard[1]);
                                Console.Write("║");
                            }
                            Console.SetCursorPosition(PositionHero.x + Display.positionBoard[0], PositionHero.y + Display.positionBoard[1]);
                            Console.Write(" ");
                            PositionHero.x++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (PositionHero.y > 1)
                        {
                            if (PositionHero.x == Display.boardDimension[0] - 1)
                            {
                                Console.SetCursorPosition(PositionHero.x + Display.positionBoard[0] + 1, PositionHero.y + Display.positionBoard[1]);
                                Console.Write("║");
                            }
                            Console.SetCursorPosition(PositionHero.x + Display.positionBoard[0], PositionHero.y + Display.positionBoard[1]);
                            Console.Write(" ");
                            PositionHero.y--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (PositionHero.y < Display.boardDimension[1]-1)
                        {
                            if (PositionHero.x == Display.boardDimension[0] - 1)
                            {
                                Console.SetCursorPosition(PositionHero.x + Display.positionBoard[0] + 1, PositionHero.y + Display.positionBoard[1]);
                                Console.Write("║");
                            }
                            Console.SetCursorPosition(PositionHero.x + Display.positionBoard[0], PositionHero.y + Display.positionBoard[1]);
                            Console.Write(" ");
                            PositionHero.y++;
                        }
                        break;
                }
                if (PositionHero.x == Display.boardDimension[0] - 1)
                {
                    Console.SetCursorPosition(PositionHero.x + Display.positionBoard[0], PositionHero.y + Display.positionBoard[1]);
                    Console.Write("H║");
                }
                else
                {
                    Console.SetCursorPosition(PositionHero.x + Display.positionBoard[0], PositionHero.y + Display.positionBoard[1]);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("H");
                    Console.ResetColor();
                }

                //CHECK IF HERO IS NEAR A MONSTER
                foreach (KeyValuePair<Monster, Coordinate> monster in monsterCoordinate)
                {
                    bool nearMonster = false;
                    for (int i = monster.Value.y - 1; i <= monster.Value.y + 1; i++)           
                    {
                        for (int j = monster.Value.x - 1; j <= monster.Value.x + 1; j++)       
                        {
                            if (j == PositionHero.x && i == PositionHero.y)
                            {

                                if(monster.Key.Alive == false)
                                {
                                    Console.SetCursorPosition(monster.Value.x + Display.positionBoard[0], monster.Value.y + Display.positionBoard[1]);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }
                                nearMonster = true;
                                Console.SetCursorPosition(monster.Value.x + Display.positionBoard[0], monster.Value.y + Display.positionBoard[1]);
                                if (monster.Key is Dragon)
                                {
                                    Console.Write("D");
                                }
                                else if (monster.Key is Orc)
                                {
                                    Console.Write("O");
                                }
                                else if (monster.Key is Wolf)
                                {
                                    Console.Write("W");
                                }
                                Console.SetCursorPosition(monster.Value.x + Display.positionBoard[0], monster.Value.y + Display.positionBoard[1]);
                                Console.ResetColor();

                                if(monster.Key.Alive == true)
                                {
                                    Display.Opponents(wil, monster.Key);
                                }
                            }
                        }
                    }
                    if (nearMonster)
                    {
                        while (wil.Alive && monster.Key.Alive)
                        {
                            wil.Attack(monster.Key);
                            //Display.CombatInfo(wil, monster.Key);
                            Display.CharacterStat(monster.Key);
                            Console.ReadKey();
                            if (monster.Key.Alive)
                            {
                                monster.Key.Attack(wil);
                                //Display.CombatInfo(monster.Key, wil);
                                Display.CharacterStat(wil);
                            }
                            else
                            {
                                Display.ClearStatArea(monster.Key);
                            }

                            if (!wil.Alive)
                            {
                                //Display.ClearCombatBoard();
                            }
                            else
                            {
                                Display.CharacterStat(wil);
                                //Display.ClearCombatBoard();
                            }
                        }
                    }
                }

                if(!wil.Alive)
                {
                    Console.ReadKey(true);
                    break;
                }
            }
        }
    }
}
