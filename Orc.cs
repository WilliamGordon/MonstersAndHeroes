using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAndHeroes
{
    class Orc : Monster
    {
        //CONSTRUCTOR
        public Orc(int x, int y) : base(x, y)
        {
            Gold = Dice.Throw4();
            Leather = 0;
            BonusStamina = 0;
            BonusStrength = 1;
        }

    }
}
