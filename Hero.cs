using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAndHeroes
{
    abstract class Hero : Character
    {
        //CONSTRUCTOR
        public Hero()
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
        public override void Attack(Character other)
        {
            base.Attack(other);
            if (!other.Alive)
            {
                this.Rest();
                this.Harvest((Monster)other);
            }
        }
    }
}
