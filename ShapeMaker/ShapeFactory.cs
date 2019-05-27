using System.Drawing;
using ShapeMaker.Contracts;
using ShapeMaker.Models;
using ShapeMaker.Models.Contracts;

namespace ShapeMaker
{
    public class ShapeFactory : IShapeFactory
    {
        public IShape CreateCicle(float centerXCoordinate, 
            float centerYCoordinate, float radius, Color color, int currentLayer)
        {
            IShape circle = new Circle(
                new PointF(centerXCoordinate, centerYCoordinate),  radius, color, currentLayer);

            return circle;
        }

        public IShape CreateRectangle(float pointXCoordinate, 
            float pointYCoordinate, float width, float height, Color color, int currentLayer)
        {
            IShape rectangle = new ShapeMaker.Models.Rectangle(
                new PointF(pointXCoordinate, pointYCoordinate), width, height,
                color, currentLayer);

            return rectangle;
        }

        public IShape CreateTriangle(float pointAXCoordinate, 
            float pointAYCoordinate, float pointBXCoordinate,
            float pointBYCoordinate, float pointCXCoordinate, 
            float pointCYCoordinate, Color color, int currentLayer)
        {
            IShape triangle = new Triangle(
                new PointF(pointAXCoordinate, pointAYCoordinate),
                new PointF(pointBXCoordinate, pointBYCoordinate),
                new PointF(pointCXCoordinate, pointCYCoordinate), color, currentLayer);

            return triangle;
        }
    }
}
