using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAndHeroes
{
    public class Sprite : ISprite
    {
        List<Coordinate> positionItem = new List<Coordinate>();
        private Coordinate _Coordinate;

        public Coordinate Coordinate
        {
            get { return _Coordinate; }
            set { _Coordinate = value; }
        }
    }
}
