using System;
using System.Collections.Generic;
using System.Text;

namespace P03_JediGalaxy
{
    public class Player
    {

        public Player(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Sum { get; set; }

        public void Move()
        {
            this.X -= 1;
            this.Y += 1;
        }
    }
}
