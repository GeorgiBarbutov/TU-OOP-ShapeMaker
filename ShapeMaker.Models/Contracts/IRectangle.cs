using System.Drawing;

namespace ShapeMaker.Models.Contracts
{
    public interface IRectangle
    {
        PointF Point { get; }
        float Width { get; }
        float Height { get; }

        void ChangeSize(PointF point, float width, float height);
    }
}
