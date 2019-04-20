using System.Drawing;

namespace ShapeMaker.Models.Contracts
{
    public interface ICircle
    {
        PointF Center { get; }
        float Radius { get; }

        void ChangeSize(PointF center, float radius);
    }
}
