﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAndHeroes
{
    public abstract class Monster : Character, ISprite
    {
        public Monster(int x, int y): base(x, y)
        {
        }
    }
}
