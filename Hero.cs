﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAndHeroes
{
    public abstract class Hero : Character, ISprite
    {
        //CONSTRUCTOR
        public Hero(int x, int y) : base(x, y)
        {
            Gold = 0;
            Leather = 0;
        }

        //METHODS
        public void Harvest(Monster monster)
        {
            this.Gold += monster.Gold;
            this.Leather += monster.Leather;
            monster.Gold = 0;
            monster.Leather = 0;
        }

        //OVERRIDEN METHODS
       

    }
}
