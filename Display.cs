using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAndHeroes
{
    static class Display
    {
        //DIMENSION AND POSITION OF TABLES
            //Main
        static int[]         positionMainContainer = new int[2] { 2, 1 };
        static int[]         dimensionMainContainer = new int[] { 125, 50 };
            //Title
        static int[]        positionTitle       = new int[2] { 20, 2 };
        static int[]        dimensionTitle      = new int[2] { 85, 6 };
            //Board - Stats
        public static int[] positionBoard       = new int[2] { 5, 9 };
        public static int[] boardDimension      = new int[2] {72, 30};

        static int[]        positionStatHero    = new int[2] { 79, 9 };
        static int[]        dimensionStatHero   = new int[2] { 40, 12 };

        static int[]        dimensionStatArea   = new int[2] { 45, 14 };

        static int[]        positionStatMonster = new int[2] { 79, 25 };
        static int[]        dimensionStatMonster   = new int[2] { 40, 12 };
        //Combat 
        static int[]        positionCombat      = new int[2] { 5, 40 };
        static int[]        dimensionCombat     = new int[2] { 119, 10 };

        //bush position
        public static int[]        firstBushPosition   = new int[2] { 1, 1 };
        public static int[]        firstBushDimension  = new int[2] { 20, 10 };

        public static int[]        secondBushPosition  = new int[2] { 50, 15 };
        public static int[]        secondBushDimension = new int[2] { 20, 10 };

        //ASCII CHARACTER
        static string[] asciiTitle = new[]
                    {
                            @"    __  ___              __              ___           ____ __                     ",
                            @"   /  |/  /__  ___ ___  / /____ _______ / _ | ___ ___ / / // /__ _______  ___ ___  ",
                            @"  / /|_/ / _ \/ _ \(_-</ __/ -_) __(_-</ __ |/ _ \/ _  / _  / -_) __/ _ \/ -_|_-<  ",
                            @" /_/  /_/\___/_//_/___/\__/\__/_/ /___/_/ |_/_//_/\_,_/_//_/\__/_/  \___/\__/___/  "
                    };

        static string[] Rocks = new[]
        {
            @"░░░",
            @"░░░",
            @"░░░",
        };

        static string[] Tree = new[]
        {
            @"  ^  ",
            @" /║\ ",
            @"//║\\",
            @"  ║  ",     
        };
       
        static string[] Dwarf = new[] {
            @"        __    ",
            @"     .-'  |   ",
            @"    /   <\|   ",
            @"   |_.- o-o   ",
            @"  / C  -._)\  ",
            @" /',        | ",
            @"|   `-,_,__,' ",
            @"(,,)====[_]=| ",
            @"  '.   ____/  ",
            @"   | -|-|_    ",
            @"   |____)_)   "

        };

        static string[] Human = new[] {
            @"       !       ",
            @"      .-.      ",
            @"    __|=|__    ",
            @"   (_/`-`\_)   ",
            @"   //\___/\\   ",
            @"   <>/   \<>   ",
            @"    \|_._|/    ",
            @"     <_I_>     ",
            @"      |||      ",
            @"     /_|_\     "
        };

        static string[] Dragon = new[] {
            @"                 ,    ",
            @"  ,_     ,     .'<_   ",
            @" _> `'-,'(__.-' __<   ",
            @" >_.--(.. )   =;`     ",
            @"       `V-'`'\/``     "
        };

        static string[] Dragon2 = new[] {
            @"       ____ __        ",
            @"      { --.\  |       ",
            @"       '-._\\ | (\___ ",
            @"           `\\|{/ ^ _)",
            @"       .'^^^^^^^  /`  ",
            @"      //\   ) ,  /    ",
            @",  _.'/  `\<-- \<     ",
            @" `^^^`     ^^   ^^    ",
        };

        static string[] Dragon3 = new[] {
            @"           ,  ,            ",
            @"           \\ \\           ",
            @"           ) \\ \\    _p_  ",
            @"           )^\))\))  /  *\ ",
            @"            \_|| || / /^`-'",
            @"   __       -\ \\--/ /     ",
            @" <'  \\___/   ___. )'      ",
            @"      `====\ )___/\\       ",
            @"           //     `'       ",
            @"           \\    /  \      "
        };

        static string[] Dragon4 = new[] {
            @"                 ",
            @"                 ",
            @" _(,  {\V/}  ,)_ ",
            @"   /\ | ' | /\   ",
            @"  //\\(o o)//\\  ",
            @"  ||::/ ^ \::||  ",
            @"  |||((   ))|||  ",
            @"  |'  \' '/  '|  ",
            @"       )I(       ",
            @"      ''`''      "
        };

        static string[] Wolf = new[] {
            @"  ,    /-.  ",
            @" ((___/ __> ",
            @" /      }   ",
            @" \ .--.(    ",
            @"  \\   \\   "
        };

        static string[] Orc = new[] {
            @"    .-.     ",
            @"  _( * )_   ",
            @" (_  :  _)  ",
            @"   / ' \    ",
            @"  (_/^\_)   "
        };

        static string[] Orc2 = new[]
        {
            @"  ,/         \.  ",
            @" ((           )) ",
            @"  \`.       ,'/  ",
            @"   )')     (`(   ",
            @" ,'`/       \,`. ",
            @"(`-(         )-')",
            @" \-'\,-''`-./`-/ ",
            @"  \-')     (`-/  ",
            @"  /`'       `'\  ",
            @" (  _       _  ) ",
            @" | ( \     / ) | ",
            @" |  `.\   /,'  | ",
            @" |    `\ /'    | ",
            @" (             ) ",
            @"  \           /  ",
            @"   \         /   ",
            @"    `.     ,'    ",
            @"      `-.-'      ",
        };

        static string[] Orc3 = new[]
       {
            @"  ,/         \.  ",
            @" ((           )) ",
            @" \-'\,-''`-./`-/ ",
            @"  \-')     (`-/  ",
            @"  /`'       `'\  ",
            @" (  (\     /)  ) ",
            @" |   `\   /'   | ",
            @"  \           /  ",
            @"   \  vvvvv  /   ",
            @"    `.     ,'    ",
            @"      `---'      ",
        };


        static string[] Wolf1 = new[]
       {
            @"      |\_/|       ",
            @"     / o o\       ",
            @"     /(   )\      ",
            @"     / \#/ \      ",
            @"     |     |      ",
            @"     | | | |      ",
            @"   (~\ | | /~)    ",
            @"  __\_|| ||_/__   ",
            @"///_//_| |_\\__\\\",
        };


        static string[] Wolf2 = new[]
       {
            @"     _        _   ",
            @"    /\\     ,'/|  ",
            @"  _|  |\-'-'_/_/  ",
            @"_'/`           \  ",
            @" /              \ ",
            @"/        'o.  |o'|",
            @"|              \/ ",
            @" \_          ___\ ",
            @"   `--._`.   \;// ",
            @"        ;-.___,'  ",
        };


        static string[] Wolf3 = new[]
       {
            @" _     ___      ",
            @"#_~`--'__ `===-,",
            @"`.`.     `#.,// ",
            @",_\_\     ## #\ ",
            @"`__.__    `####\",
            @"     ~~\ ,###'~ ",
            @"        \##' |  ",
        };

        static string[] sword = new[]
        {
            @"      /|                  ",
            @"O|===|*>≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣>",
            @"      \|                  ",
        };

        static string[] punch = new[]
       {
            @" ____  _   _ _   _  ____ _   _ ",
            @"|  _ \| | | | \ | |/ ___| | | |",
            @"| |_) | | | |  \| | |   | |_| |",
            @"|  __/| |_| | |\  | |___|  _  |",
            @"|_|    \___/|_| \_|\____|_| |_|",
           
        };

        static string[] kick = new[]
       {
            @" _  _____ ____ _  __",
            @"| |/ |_ _/ ___| |/ /",
            @"| ' / | | |   | ' / ",
            @"| . \ | | |___| . \ ",
            @"|_|\_|___\____|_|\_\",

        };


        //PRINTING BOARD PART
        private static void Table(int x, int y, int width, int height)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("╔");

            Console.SetCursorPosition(x + width, y);
            Console.Write("╗");

            Console.SetCursorPosition(x, height + y);
            Console.Write("╚");

            Console.SetCursorPosition(x + width, height + y);
            Console.Write("╝");

            for (int i = 1; i < width; i++)
            {
                Console.SetCursorPosition(i + x, 0 + y);        //LIGNE HORIZONTAL - UP
                Console.Write("═");
                Console.SetCursorPosition(i + x, height + y);   //LIGNE HORIZONTAL - DOWN
                Console.Write("═");
            }
            for (int i = 1; i < height; i++)
            {
                Console.SetCursorPosition(0 + x, i + y);       //LIGNE VERTICAL - LEFT
                Console.Write("║");
                Console.SetCursorPosition(width + x, i + y);   //LIGNE VERTICAL - RIGHT
                Console.Write("║");
            }
        }
        public static void MainContainer()
        {
            Display.Table(positionMainContainer[0], positionMainContainer[1], dimensionMainContainer[0], dimensionMainContainer[1]);
        }
        public static void Title()
        {
            Display.Table(positionTitle[0], positionTitle[1], dimensionTitle[0], dimensionTitle[1]);
            Display.title();
        }
        public static void Board()
        {
            Display.Table(positionBoard[0], positionBoard[1], boardDimension[0], boardDimension[1]);
        }
        public static void MonsterStatArea()
        {
            Display.Table(positionStatMonster[0], positionStatMonster[1], dimensionStatArea[0], dimensionStatArea[1]);
        }
        public static void HeroStatArea()
        {
            Display.Table(positionStatHero[0], positionStatHero[1], dimensionStatArea[0], dimensionStatArea[1]);
        }
        public static void CombatArea()
        {
            Display.Table(positionCombat[0], positionCombat[1], dimensionCombat[0], dimensionCombat[1]);
        }

        public static void Attacks(Hero hero, int nb)
        {
            if(hero is Human)
            {
                int count = 8;

                for (int i = 0; i < ((Human)hero).Attacks.Count; i++)
                {
                    Console.SetCursorPosition(positionCombat[0] + (count ), positionCombat[1] + 2);
                    if(nb == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if(i == 0)
                    {
                        Console.Write(((Human)hero).Attacks[i] + " Range {0}-{1}", 1 + hero.Mod(hero.Strengh), 10 + hero.Mod(hero.Strengh));
                        Display.Ascii(positionCombat[0] - 4  + count, positionCombat[1] + 4, punch);
                    }
                    if(i == 1)
                    {
                        Console.Write(((Human)hero).Attacks[i] + " Range {0}-{1}", 4 + hero.Mod(hero.Strengh), 7 + hero.Mod(hero.Strengh));
                        Display.Ascii(positionCombat[0] - 5 + count, positionCombat[1] + 5, sword);
                    }
                    if (i == 2)
                    {
                        Console.Write(((Human)hero).Attacks[i] + " Range {0}-{1}", 4 + hero.Mod(hero.Strengh), 5 + hero.Mod(hero.Strengh));
                        Display.Ascii(positionCombat[0] - 5 + count, positionCombat[1] + 4, kick);
                    }
                    count += 45;
                    Console.ResetColor();
                }
            }
        }
    

        public static void Bush()
        {
            for (int i = 0; i < firstBushDimension[1]; i++)
            {
                for (int j = 0; j < firstBushDimension[0]; j++)
                {
                    Console.SetCursorPosition(Display.firstBushPosition[0] + Display.positionBoard[0] + j, firstBushPosition[1] + Display.positionBoard[1] + i);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("░");
                    Console.ResetColor();
                }
            }

            for (int i = 0; i < secondBushDimension[1]; i++)
            {
                for (int j = 0; j < secondBushDimension[0]; j++)
                {
                    Console.SetCursorPosition(Display.secondBushPosition[0] + Display.positionBoard[0] + j, Display.secondBushPosition[1] + Display.positionBoard[1] + i);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("░");
                    Console.ResetColor();
                }
            }
        }

        //CLEARING THE TABLE METHODS
        public static void ClearStatArea(Character character)
        {
            int x = 0;
            int y = 0;


            if (character is Hero)
            {
                x = positionStatHero[0];
                y = positionStatHero[1];
            }
            else
            {
                x = positionStatMonster[0];
                y = positionStatMonster[1];
            }


            for (int i = 1; i < dimensionStatArea[1]; i++)
            {
                string str = "";
                Console.SetCursorPosition(x + 2, y + i);
                Console.Write(str.PadRight(dimensionStatArea[0] - 2));
            }
        }
        public static void ClearCombatBoard()
        {
            for (int i = 1; i < 7; i++)
            {
                Console.SetCursorPosition(positionCombat[0] + 2, positionCombat[1] + i);
                Console.Write("                                        ");
            }
        }

        //DISPLAY HERO POSITION
        public static void HeroPosition(Hero hero)
        {
            Console.SetCursorPosition(hero.Coordinate.x + Display.positionBoard[0], hero.Coordinate.y + Display.positionBoard[1]);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("H");
            Console.ResetColor();
        }
        public static void ClearHeroPosition(Hero hero)
        {
            Console.SetCursorPosition(hero.Coordinate.x + Display.positionBoard[0], hero.Coordinate.y + Display.positionBoard[1]);

            bool isBush = false;

            for (int i = 0; i < Display.firstBushDimension[1]; i++)
            {
                for (int j = 0; j < Display.firstBushDimension[0]; j++)
                {
                    if (j + firstBushPosition[0] == hero.Coordinate.x && i + firstBushPosition[1] == hero.Coordinate.y)
                    {
                        isBush = true;
                    }
                }
            }

            for (int i = 0; i < Display.secondBushDimension[1]; i++)
            {
                for (int j = 0; j < Display.secondBushDimension[0]; j++)
                {
                    if (j + secondBushPosition[0] == hero.Coordinate.x && i + secondBushPosition[1] == hero.Coordinate.y)
                    {
                        isBush = true;
                    }
                }
            }

            if(isBush)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("░");
                Console.ResetColor();
            }
            else
            {
                Console.Write(" ");
            }

        }

        //DISPLAY MONSTER
        public static void MonsterPosition(Monster monster)
        {
            Console.SetCursorPosition(monster.Coordinate.x + Display.positionBoard[0], monster.Coordinate.y + Display.positionBoard[1]);
            if (monster is Dragon)
            {
                Console.Write("D");
            }
            else if (monster is Orc)
            {
                Console.Write("O");
            }
            else if (monster is Wolf)
            {
                Console.Write("W");
            }
            Console.SetCursorPosition(monster.Coordinate.x + Display.positionBoard[0], monster.Coordinate.y + Display.positionBoard[1]);
        }
        public static void DeadMonster(Monster monster)
        {
            Console.SetCursorPosition(monster.Coordinate.x + Display.positionBoard[0], monster.Coordinate.y + Display.positionBoard[1]);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("X");
            Console.ResetColor();
        }

        //PRINTING STATS
            //HERO AND MONSTER STATS

        private static string FormatStringByAddingSpace(string str)
        {
            int lengthDesired = 10;
            int inputLength = str.Length;
            int nbSpaceNeeded = lengthDesired - inputLength;

            return "";
        }
        private static string[] GetAscii(Character character)
        {
            switch (character.GetInfoPerso()["Class"])
            {
                case "Dwarf":
                    return Dwarf;
                case "Human":
                    return Human;
                case "Dragon":
                    return Dragon4;
                case "Orc":
                    return Orc3;
                case "Wolf":
                    return Wolf2;
                default:
                    return null;
            }
        }
        public static void XPBar(Character character)
        {
            int x = 0;
            int y = 0;

            if (character is Hero)
            {
                x = positionStatHero[0];
                y = positionStatHero[1];
            }
            else
            {
                x = positionStatMonster[0];
                y = positionStatMonster[1];
            }

            int xOffSet = 21;
            int yOffSet = y + 4;

            Console.SetCursorPosition(x + xOffSet-2, yOffSet - 1);
            string leftXPStr = "▀";
            Console.Write("XP ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int i = 0; i < (int)Math.Round(((double)character.XP / character.XPThreshold) * 15); i++)
            {
                Console.Write(leftXPStr);
            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 0; i < Math.Abs((int)Math.Round(((double)character.XP / character.XPThreshold) * 15) - 15); i++)
            {
                Console.Write(leftXPStr);
            }
            Console.ResetColor();
            Console.Write(" {0}/{1}", character.XP.ToString().PadLeft(2), character.XPThreshold.ToString().PadLeft(2));
        }
        public static void HealthBar(Character character)
        {
            int x = 0;
            int y = 0;

            if (character is Hero)
            {
                x = positionStatHero[0];
                y = positionStatHero[1];
            }
            else
            {
                x = positionStatMonster[0];
                y = positionStatMonster[1];
            }

            int xOffSet = 21;
            int yOffSet = y + 3;

            Console.SetCursorPosition(x + xOffSet -2, yOffSet - 1);
            string leftHPStr = "▀";
            Console.Write("HP ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 0; i < (int)Math.Round(((double)character.HP / character.MaxHP) * 15); i++)
            {
                Console.Write(leftHPStr);
            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < Math.Abs((int)Math.Round(((double)character.HP / character.MaxHP) * 15) - 15); i++)
            {
                Console.Write(leftHPStr);
            }
            Console.ResetColor();
            Console.Write(" {0}/{1}", character.HP.ToString().PadLeft(2), character.MaxHP.ToString().PadLeft(2));
        }
        public static void RefreshStat(Character character)
        {
            int x = 0;
            int y = 0;


            if (character is Hero)
            {
                x = positionStatHero[0];
                y = positionStatHero[1];
            }
            else
            {
                x = positionStatMonster[0];
                y = positionStatMonster[1];
            }

            int xOffSet = 21;
            int yOffSet = y + 3;

            //Console.SetCursorPosition(x + xOffSet - 2, yOffSet - 1);
            Display.HealthBar(character);

            if(character is Hero)
            {
                Display.XPBar(character);
                Console.SetCursorPosition(x + xOffSet, yOffSet + 2);
                Console.WriteLine("Level:".PadRight(10) + character.Level);
                Console.SetCursorPosition(x + xOffSet, yOffSet + 3);
                Console.WriteLine("Strength:".PadRight(10) + character.Strengh);
                Console.SetCursorPosition(x + xOffSet, yOffSet + 4);
                Console.WriteLine("Stamina:".PadRight(10) + character.Stamina);
            }

            Console.SetCursorPosition(x + xOffSet, yOffSet + 7);
            if (!character.Alive)
            {
                Console.Write("State".PadRight(10));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("DEAD".PadRight(5));
                Console.ResetColor();
            }

        }
        public static void ClearHealthBar(Character character)
        {
            int x = 0;
            int y = 0;


            if (character is Hero)
            {
                x = positionStatHero[0];
                y = positionStatHero[1];
            }
            else
            {
                x = positionStatMonster[0];
                y = positionStatMonster[1];
            }

            int xOffSet = 21;
            int yOffSet = y + 3;

            Console.SetCursorPosition(x + xOffSet, yOffSet - 1);
            Console.Write("                ");
        }
        public static void Stats(Character character)
        {
            int x = 0;
            int y = 0;


            if (character is Hero)
            {
                x = positionStatHero[0];
                y = positionStatHero[1];
            }
            else
            {
                x = positionStatMonster[0];
                y = positionStatMonster[1];
            }

            int xOffSet = 21;
            int yOffSet = y + 4;

            foreach (KeyValuePair<string, string> stat in character.GetInfoPerso())
            {
                Console.SetCursorPosition(x + xOffSet, yOffSet++);
                if (stat.Value == "DEAD")
                {
                    Console.Write(stat.Key.PadRight(10));
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(stat.Value);
                    Console.ResetColor();
                }
                else if (stat.Value == "ALIVE")
                {
                    Console.Write(stat.Key.PadRight(10));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(stat.Value);
                    Console.ResetColor();
                }
                else
                {
                    Console.Write("{0}{1}", stat.Key.Insert(stat.Key.Length, ":").PadRight(10), stat.Value);
                }
            }
        }
        public static void CharacterStat(Character character)
        {
            int x = 0;
            int y = 0;
           

            if (character is Hero)
            {
                x = positionStatHero[0];
                y = positionStatHero[1];
            }
            else
            {
                x = positionStatMonster[0];
                y = positionStatMonster[1];
            }

            Display.Ascii(x + 2, y + 1, Display.GetAscii(character));

            int xOffSet = 21;
            int yOffSet = y + 3;
           
            Console.SetCursorPosition(x + xOffSet, yOffSet - 1);
            Display.HealthBar(character);
            Display.Stats(character);

        }
       
        //PRINT ASCII
        public static void Knight(int x, int y)
        {
            int counter = y;
            foreach (string line in Human)
            {
                Console.SetCursorPosition(x, y++);
                Console.Write(line);
            }
        }
        public static void title()
        {
            int counter = positionTitle[1] + 1;
            foreach (string line in asciiTitle)
            {
                Console.SetCursorPosition(positionTitle[0] + 2, counter);
                Console.Write(line);
                counter++;
            }
        }
        public static void Ascii(int x, int y, string[] asci)
        {
            int counter = y;
            foreach (string line in asci)
            {
                Console.SetCursorPosition(x, y++);
                Console.Write(line);
            }
        }
        public static void Three()
        {
            Ascii(20, 20, Tree);
        }
    }
}
