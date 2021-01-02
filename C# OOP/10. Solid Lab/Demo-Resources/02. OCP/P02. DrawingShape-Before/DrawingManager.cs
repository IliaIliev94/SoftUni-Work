using P02._DrawingShape_Before.Contracts;
using System.Collections.Generic;
using System.Linq;
namespace P02._DrawingShape_Before.Strategy
{
    public class DrawingManager : IDrawingManager
    {
        private List<IDrawingStrategy> strategies;

        public DrawingManager()
        {
            strategies = new List<IDrawingStrategy>()
            {
                new CircleDrawer(),
                new RectangleDrawer()
            };
        }
        public void Draw(IShape shape)
        {
            IDrawingStrategy drawingStrategy = strategies.First(s => s.IsMatch(shape));
            drawingStrategy.Draw(shape);
        }

    }
}
