using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAndHeroes
{
    class Dwarf : Hero, ISprite
    {
        //CONSTRUCTOR
        public Dwarf(int x, int y) : base(x, y)
        {
            BonusStamina = 0;
            BonusStrength = 2;
        }
    }
}
