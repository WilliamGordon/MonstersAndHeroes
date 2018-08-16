using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAndHeroes
{
    public abstract class Character 
    {
        //PROPRIETIES
        private bool _Alive;
        private int _Strengh;
        private int _Stamina;
        private int _HP;
        private int _Gold;
        private int _Leather;
        private int _MaxHP;
        private int _BonusStrength;
        private int _BonusStamina;
        private int _tempDamage;
        private Coordinate _Coordinate;

        public Coordinate Coordinate
        {
            get { return _Coordinate; }
            set { _Coordinate = value; }
        }

        public int TempDamage
        {
            get { return _tempDamage; }
        }


        public int BonusStrength
        {
            get { return _BonusStrength; }
            set { _BonusStrength = value; }
        }
        public int BonusStamina
        {
            get { return _BonusStamina; }
            set { _BonusStamina = value; }
        }
        public int MaxHP
        {
            get { return _MaxHP; }
        }
        public int Leather
        {
            get { return _Leather; }
            set { _Leather = value; }
        }
        public int Gold
        {
            get { return _Gold; }
            set { _Gold = value; }
        }
        public bool Alive
        {
            get { return _Alive; }
        }
        public int Strengh
        {
            get { return _Strengh; }
        }
        public int Stamina
        {
            get { return _Stamina; }
        }
        public int HP
        {
            get { return _HP; }
        }

        public Character(int x, int y)
        {
            _Strengh = Dice.Thow4TimesGetBest3() + BonusStrength;
            _Stamina = Dice.Thow4TimesGetBest3() + BonusStamina;
            if (this is Human)
            {
                _HP = 99;
            }
            else
            {
                _HP = Stamina + Mod(Stamina);
            }
            _MaxHP = this.HP;
            _Alive = true;
            this._Coordinate.x = x;
            this._Coordinate.y = y;
        }

        //METHODS
        public void Move(string direction)
        {
            if(direction == "left")
            {
                this._Coordinate.x--;
            }

            if(direction == "right")
            {
                this._Coordinate.x++;
            }

            if (direction == "down")
            {
                this._Coordinate.y++;
            }

            if (direction == "up")
            {
                this._Coordinate.y--;
            }
        }

        public virtual void Attack(Character other)
        {
            if(other.Alive && this.Alive)
            {
                int damage = Dice.Throw() + Mod(Strengh);
                other._HP -= damage;
                _tempDamage = damage;
                if(other.HP <= 0)
                {
                    other.Dead();
                    other._HP = 0;
                }
            }
        }
        public void Dead()
        {
            if(HP <= 0)
            {
                _Alive = false;
            }
        }
        public void Rest()
        {
            this._HP = this._MaxHP;
        }

        

        public int Mod(int num)
        {
            if (num < 5)
            {
                return -1;
            }
            else if (num >= 5 && num < 10)
            {
                return 0;
            }
            else if (num >= 10 && num < 15)
            {
                return 1;
            }

            return 2;
        }


        //OVERRIDE METHODS OBJECT
        public override string ToString()
        {
            return "Class " + this.GetType().ToString().Substring(18) 
                +       "\t| Strength " + Strengh 
                +       "\t| Stamina " + Stamina 
                +       "\t| HP " + HP
                +       "\t| MAXHP " + MaxHP
                +       "  \t| Gold " + Gold
                +       "\t| Leather " + Leather
                +       "  \t| " + ((Alive) ? "ALIVE" : "DEAD");
        }

        public Dictionary<string, string> GetInfoPerso()
        {
            Dictionary<string, string> infoPerso = new Dictionary<string, string>();
            infoPerso.Add("Class", this.GetType().ToString().Substring(18));
            infoPerso.Add("Strength", Strengh.ToString());
            infoPerso.Add("Stamina", Stamina.ToString());
            infoPerso.Add("Gold", Gold.ToString());
            infoPerso.Add("Leather", Leather.ToString());
            infoPerso.Add("State", ((Alive) ? "ALIVE" : "DEAD"));

            return infoPerso;
        }

    }
}
