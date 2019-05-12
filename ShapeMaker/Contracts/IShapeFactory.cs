using ShapeMaker.Models.Contracts;
using System.Drawing;

namespace ShapeMaker.Contracts
{
    public interface IShapeFactory
    {
        IShape CreateTriangle(float pointAXCoordinate, float pointAYCoordinate,
            float pointBXCoordinate, float pointBYCoordinate,
            float pointCXCoordinate, float pointCYCoordinate, Color color);

        IShape CreateRectangle(float pointXCoordinate, float pointYCoordinate,
            float width, float height, Color color);

        IShape CreateCicle(float centerXCoordinate, float centerYCoordinate,
            float radius, Color color);
    }
}
