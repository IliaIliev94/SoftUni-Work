using System;
using System.Collections.Generic;
using System.Text;
using P02._DrawingShape_Before.Contracts;

namespace P02._DrawingShape_Before.Strategy
{
    public class CircleDrawer : IDrawingStrategy
    {
        public void Draw(IShape shape)
        {
            var circle = shape as Circle;
            Console.WriteLine($"Drawing circle {circle}");
        }

        public bool IsMatch(IShape shape)
        {
            return shape is Circle;
        }
    }
}
