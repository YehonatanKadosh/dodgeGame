using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangleExample.models
{
    internal class Player : Piece
    {
        public Player(int x, int y) : base(x, y, 50, 50)
        {
        }
    }
}
