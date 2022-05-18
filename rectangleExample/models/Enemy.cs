using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangleExample.models
{
    internal class Enemy : Piece
    {
        public Enemy(int x, int y) : base(x, y, 30, 30)
        {
        }
    }
}
