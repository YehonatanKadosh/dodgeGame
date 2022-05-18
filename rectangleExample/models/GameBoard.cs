using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangleExample.models
{
    internal class GameBoard
    {
        public Player pini;
        public Enemy[] enemies;
        public double _boardWidth;
        public double _boardHeight;
        Random random = new Random();

        public GameBoard(double boardWidth, double boardHeight)
        {
            _boardHeight = boardHeight;
            _boardWidth = boardWidth;


            pini = new Player((int)_boardWidth / 2 - 25, (int)_boardHeight / 2 - 25);
            enemies = new Enemy[10];
            for (int i = 0; i < 10; i++)
                enemies[i] = new Enemy(random.Next(30, (int)_boardWidth - 30), random.Next(30, (int)_boardHeight - 30));

        }
    }
}
