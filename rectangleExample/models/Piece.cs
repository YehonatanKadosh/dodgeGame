using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangleExample.models
{
    public class Piece
    {
        public int _x;
        public int _y;
        public int _width;
        public int _height;

        public Piece(int x, int y, int width, int height)
        {
            this._x = x;
            this._y = y;
            this._width = width;
            this._height = height;
        }

    }
}
