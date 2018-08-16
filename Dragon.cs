using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAndHeroes
{
    class Dragon : Monster, ISprite
    {
        //CONSTRUCTOR

        public Dragon(int x, int y): base(x, y)
        {
            Gold = Dice.Throw4();
            Leather = Dice.Throw4();
            BonusStamina = 0;
            BonusStrength = 1;
        }
    }
}
