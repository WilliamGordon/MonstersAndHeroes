using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAndHeroes
{
    class Human : Hero, ISprite
    {

        private List<string> _Attacks = new List<string> { "Sucker Punch", "Sword Slash", "Kick" };

        public List<string> Attacks
        {
            get { return _Attacks; }
        }

        //CONSTRUCTOR
        public Human(int x, int y) : base(x, y)
        {
            BonusStamina = 1;
            BonusStrength = 1;
        }

        //DOES NOT NEED TO BE OVERRIDEN ???
        public override void Attack(Character other, int nb)
        {
            if (other.Alive && this.Alive)
            {
                int damage = 0;

                if (nb == 0)
                {
                    damage = this.SuckerPunch();
                    other.ReceiveDamage(damage);
                }
                else if(nb == 1)
                {
                    damage = this.SwordHit();
                    other.ReceiveDamage(damage);
                }
                else if (nb == 2)
                {
                    damage = this.Kick();
                    other.ReceiveDamage(damage);
                }
                else
                {
                    damage = this.Kick();
                    other.ReceiveDamage(damage);
                }
                
                this._tempDamage = damage;
                if (other.HP <= 0)
                {
                    this._XP += 10;
                    if (this.XP >= this.XPThreshold)
                    {
                        this.LevelUp();
                    }
                    other.Dead();
                    other.ReceiveDamage(other.HP);
                }
            }
            if (!other.Alive)
            {
                this.Rest();
                this.Harvest((Monster)other);
            }
        }

        public int SuckerPunch()
        {
            int damage = Dice.ThrowChoose(1,10) + Mod(Strengh); 
            return damage;
        }
        public int SwordHit()
        {
            int damage = Dice.ThrowChoose(4, 7) + Mod(Strengh);
            return damage;
        }
        public int Kick()
        {
            int damage = Dice.ThrowChoose(4, 5) + Mod(Strengh);
            return damage;
        }

    }
}
