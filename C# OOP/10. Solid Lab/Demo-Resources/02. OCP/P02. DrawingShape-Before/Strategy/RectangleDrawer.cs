using System;
using System.Collections.Generic;
using System.Text;
using P02._DrawingShape_Before.Contracts;

namespace P02._DrawingShape_Before.Strategy
{
    public class RectangleDrawer : IDrawingStrategy
    {
        public void Draw(IShape shape)
        {
            var rectangle = shape as Rectangle;
            Console.WriteLine($"Drawing rectangle {rectangle}");
        }

        public bool IsMatch(IShape shape)
        {
            return shape is Rectangle;
        }
    }
}
