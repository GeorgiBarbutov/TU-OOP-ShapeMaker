using ShapeMaker.Models.Contracts;
using System.Drawing;

namespace ShapeMaker.Models
{
    public class Rectangle : Shape, IRectangle
    {
        public Rectangle(PointF point, float width, float height, Color color) : base(color)
        {
            SetValues(point, width, height);
        }

        public PointF Point { get; private set; }

        public float Width { get; private set; }

        public float Height { get; private set; }

        public void ChangeSize(PointF point, float width, float height)
        {
            SetValues(point, width, height);
        }

        private void SetValues(PointF point, float width, float height)
        {
            this.Point = point;
            this.Width = width;
            this.Height = height;
        }

        public override void Draw(Graphics graphics)
        {
            Brush brush = new SolidBrush(this.color);

            graphics.FillRectangle(brush, this.Point.X, this.Point.Y, this.Width, this.Height);
        }

        /// <summary>
        ///     Changes the coordinates by a specific offset.
        /// </summary>
        /// <param name="rightOffset">
        ///     Positive value will move the figure to the right and negative value will move the figure to the left.
        /// </param>
        /// <param name="downOffset">
        ///     Positive value will move the figure to the down and negative value will move the figure to the up.
        /// </param>
        public override void Move(float rightOffset, float downOffset)
        {
            this.Point = new PointF(this.Point.X + rightOffset, this.Point.Y + downOffset);
        }

        public override float CalculateArea()
        {
            float area = this.Width * this.Height;

            return area;
        }
    }
}
