using System.Drawing;

namespace ShapeMaker.Models.Contracts
{
    public interface ITriangle
    {
        PointF PointA { get; }
        PointF PointB { get; }
        PointF PointC { get; }

        void ChangeSize(PointF pointA, PointF pointB, PointF pointC);
    }
}
