using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAndHeroes
{
    class Human : Hero, ISprite
    {
        //CONSTRUCTOR
        public Human(int x, int y) : base(x, y)
        {
            BonusStamina = 1;
            BonusStrength = 1;
        }

    }
}
