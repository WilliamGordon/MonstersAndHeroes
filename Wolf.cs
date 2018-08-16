using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAndHeroes
{
    class Wolf : Monster, ISprite
    {
        //CONSTRUCTOR
        public Wolf(int x, int y) : base(x, y)
        {
            Gold = 0;
            Leather = 0;
            BonusStamina = 0;
            BonusStrength = 0;
        }
    }
}
