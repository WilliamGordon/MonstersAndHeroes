using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAndHeroes
{
    static class Dice
    {
        //PROPRIETIES
        private static Random r = new Random();
        private static int _Min = 1;
        private static int _Max = 7;

        public static int Min
        {
            get { return _Min; }
        }
        public static int Max
        {
            get { return _Max; }
        }

        //STATIC METHODS
        public static int ThrowChoose(int min, int max)
        {
            return r.Next(min, max);
        }
        public static int Throw()
        {
            return r.Next(Min, Max);
        }
        public static int Throw4()
        {
            return r.Next(Min, Max - 2);
        }
        public static int Thow4TimesGetBest3()
        {
            List<int> fourThrows = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                fourThrows.Add(Dice.Throw());
            }
            return fourThrows.Sum() - fourThrows.Min();
        }

    }
}
