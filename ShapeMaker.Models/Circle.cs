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

            graphics.FillEllipse(brush, this.Center.X - this.Radius, this.Center.Y - this.Radius, 
                this.Radius * 2, this.Radius * 2);

            brush.Dispose();
        }

        public override void Outline(Graphics graphics, Color color)
        {
            Pen pen = new Pen(color, 2);

            graphics.DrawEllipse(pen, this.Center.X - this.Radius, this.Center.Y - this.Radius,
                this.Radius * 2, this.Radius * 2);

            pen.Dispose();
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

        public override bool Contains(PointF point)
        {
            if ((point.X - this.Center.X) * (point.X - this.Center.X) +
                (point.Y - this.Center.Y) * (point.Y - this.Center.Y) <= this.Radius * this.Radius)
                return true;
            else
                return false;
        }
    }
}
