using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAndHeroes
{
    class Dragon : Monster
    {
        //CONSTRUCTOR
        public Dragon()
        {
            Gold = Dice.Throw4();
            Leather = Dice.Throw4();
            BonusStamina = 0;
            BonusStrength = 1;
        }
    }
}
