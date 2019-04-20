using ShapeMaker.Models.Contracts;
using System;
using System.Drawing;

namespace ShapeMaker.Models
{
    public class Circle : Shape, ICircle
    {
        public Circle(PointF center, float radius, Color color) : base(color)
        {
            SetValues(center, radius);
        }

        public PointF Center { get; private set; }

        public float Radius { get; private set; }

        public void ChangeSize(PointF center, float radius)
        {
            SetValues(center, radius);
        }

        private void SetValues(PointF center, float radius)
        {
            this.Center = center;
            this.Radius = radius;
        }

        public override void Draw(Graphics graphics)
        {
            Brush brush = new SolidBrush(this.color);

            graphics.FillEllipse(brush, this.Center.X, this.Center.Y, this.Radius, this.Radius);
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
            this.Center = new PointF(this.Center.X + rightOffset, this.Center.Y + downOffset);
        }

        public override float CalculateArea()
        {
            float area = (float)Math.PI * this.Radius * this.Radius;

            return area;
        }
    }
}
