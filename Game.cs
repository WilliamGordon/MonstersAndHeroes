using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAndHeroes
{
    public class Game
    {
        Hero hero;
        Coordinate PositionHero = new Coordinate(1, 1);
        List<ISprite> ListSprite = new List<ISprite>();
        List<Monster> ListMonsters = new List<Monster>();
        Random newRand = new Random();

        public void Initialisation(string HeroClass)
        {
            //INITIALISATION HERO
            if (HeroClass == "Human")
            {
                hero = new Human(1,1);
            }
            else
            {
                hero = new Dwarf(1,1);
            }

            //ADDING THREES



            //INITIALISATION MONSTER AND POSITION
            ListSprite.Add(new Dragon(newRand.Next(1, 15), newRand.Next(1, 15))) ;
            int tempX = 0;
            int tempY = 0;

            for (int k = 0; k < 80;)
            {
                //COORDINATE NEW MONSTER
                tempX = newRand.Next(1, Display.boardDimension[0]);
                tempY = newRand.Next(1, Display.boardDimension[1]);
                bool goodCoordinate = true;

                //LOOP TROUGH COORDINATE OF THE OTHER MONSTER TO CHECK IF COORDINATE OF NEW MONSTER ARE VALID
                foreach (Monster monster in ListSprite)
                {
                    //CHECK PATTERN
                    for (int i = monster.Coordinate.y - 2; i <= monster.Coordinate.y + 2; i++)           // Y COORDINATE
                    {
                        for (int j = monster.Coordinate.x - 2; j <= monster.Coordinate.x + 2; j++)       // X COORDINATE
                        {

                            if ((j == monster.Coordinate.x || i == monster.Coordinate.y)
                                ||
                               ((j < monster.Coordinate.x + 2) && (j > monster.Coordinate.x - 2)) && ((i < monster.Coordinate.y + 2) && (i > monster.Coordinate.y - 2)))
                            {
                                if (j == tempX && i == tempY)
                                {
                                    goodCoordinate = false;
                                }
                            }
                        }
                    }
                }

                for (int i = 1; i < 10; i++)
                {
                    for (int j = 1; j < 10; j++)
                    {
                        if(j == tempX && i == tempY)
                        {
                            goodCoordinate = false;
                        }
                        
                    }
                }

                for (int i = 10; i < 25; i++)
                {
                    for (int j = 10; j < 50; j++)
                    {
                        if (j == tempX && i == tempY)
                        {
                            goodCoordinate = false;
                        }
                        
                    }
                }

               


                if (goodCoordinate)
                {
                    switch (newRand.Next(1, 4))
                    {
                        case 1:
                            ListSprite.Add(new Dragon(tempX, tempY));
                            break;
                        case 2:
                            ListSprite.Add(new Wolf(tempX, tempY));
                            break;
                        case 3:
                            ListSprite.Add(new Orc(tempX, tempY));
                            break;
                    }
                    k++;
                }
            }
        }
        public void Navigation(ConsoleKey key)
        {
            Display.HeroPosition(hero);
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    if (hero.Coordinate.x > 1)
                    {
                        Display.ClearHeroPosition(hero);
                        hero.Move("left");
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (hero.Coordinate.x < Display.boardDimension[0] - 1)
                    {
                        Display.ClearHeroPosition(hero);
                        hero.Move("right");
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (hero.Coordinate.y > 1)
                    {
                        Display.ClearHeroPosition(hero);
                        hero.Move("up");
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (hero.Coordinate.y < Display.boardDimension[1] - 1)
                    {
                        Display.ClearHeroPosition(hero);
                        hero.Move("down");
                    }
                    break;
            }
            Display.HeroPosition(hero);
        }
        public Monster NearAMonster()
        {
            foreach (Monster monster in ListSprite)
            {
                for (int i = monster.Coordinate.y - 1; i <= monster.Coordinate.y + 1; i++)
                {
                    for (int j = monster.Coordinate.x - 1; j <= monster.Coordinate.x + 1; j++)
                    {
                        if (j == hero.Coordinate.x && i == hero.Coordinate.y)
                        {
                            if (monster.Alive == true)
                            {
                                Display.MonsterPosition(monster);
                            }
                            else
                            {
                                Display.DeadMonster(monster);
                                Display.HeroPosition(hero);
                            }
                            return monster;
                        }
                    }
                }
            }
            return null;
        }
        public void Combat(Hero hero, Monster monster)
        {
            while (hero.Alive && monster.Alive)
            {
                if(monster.Alive)
                {
                    Display.CharacterStat(monster);
                    Console.ReadKey(true);
                }
                hero.Attack(monster);
                Display.RefreshStat(monster);
                Console.ReadKey(true);
                if (monster.Alive)
                {
                    monster.Attack(hero);
                    Display.RefreshStat(hero);
                }
                else
                {
                    Display.DeadMonster(monster);
                    Display.RefreshStat(hero);
                    Display.ClearStatArea(monster);
                }
            }
        }
        public void UpDate(ConsoleKey key)
        {
            Navigation(key);
            Monster nearestMonster = NearAMonster();
            if (nearestMonster != null)
            {
                Combat(hero, nearestMonster);
            }
        }
        public void SetupBoard()
        {
            Display.MainContainer();
            Display.Title();
            Display.Board();
            Display.CharacterStat(hero);
            Display.MonsterStatArea();
            Display.HeroStatArea();
        }
      
    }
}
