using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAndHeroes
{
    class Human : Hero
    {
        //CONSTRUCTOR
        public Human(): base()
        {
            BonusStamina = 1;
            BonusStrength = 1;
        }

    }
}
