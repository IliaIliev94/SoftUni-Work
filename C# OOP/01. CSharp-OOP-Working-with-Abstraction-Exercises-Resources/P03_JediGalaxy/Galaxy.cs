using System;
using System.Collections.Generic;
using System.Text;

namespace P03_JediGalaxy
{
    public class Galaxy
    {
        private int[,] stars;

        public int Length
        {
            get
            {
                return this.stars.GetLength(0);
            }
        }

        public int Width
        {
            get
            {
                return this.stars.GetLength(1);
            }
        }

        public Galaxy(int length, int width)
        {
            this.stars = new int[length,width];
        }
        public int this[int length, int width]
        {
            get
            {
                return stars[length, width];
            }
            set
            {
                this.stars[length, width] = value;
            }
        }
    }
}
