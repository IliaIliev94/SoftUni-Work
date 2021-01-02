using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int height;
        private int width;

        public Rectangle(int width, int height)
        {
            this.height = height;
            this.width = width;
        }

        public void Draw()
        {
            for(int i = 0; i < this.height; i++)
            {
                Console.Write("*");
                for(int j = 0; j < this.width - 2; j++)
                {
                    if(i == 0 || i == this.height - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("*");
                Console.WriteLine();
            }
        }


    }
}
