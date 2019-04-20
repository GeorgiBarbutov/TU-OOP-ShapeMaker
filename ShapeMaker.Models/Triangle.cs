using ShapeMaker.Models.Contracts;
using System;
using System.Drawing;

namespace ShapeMaker.Models
{
    public class Triangle : Shape, ITriangle
    {
        public Triangle(PointF pointA, PointF pointB, PointF pointC, Color color) : base(color)
        {
            SetValues(pointA, pointB, pointC);
        }

        public PointF PointA { get; private set; }

        public PointF PointB { get; private set; }

        public PointF PointC { get; private set; }

        public void ChangeSize(PointF pointA, PointF pointB, PointF pointC)
        {
            SetValues(pointA, pointB, pointC);
        }

        private void SetValues(PointF pointA, PointF pointB, PointF pointC)
        {
            this.PointA = pointA;
            this.PointB = pointB;
            this.PointC = pointC;
        }

        public override void Draw(Graphics graphics)
        {
            Brush brush = new SolidBrush(this.color);
            
            graphics.FillPolygon(brush, new PointF[] { this.PointA, this.PointB, this.PointC });
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
            this.PointA = new PointF(this.PointA.X + rightOffset, this.PointA.Y + downOffset);
            this.PointB = new PointF(this.PointB.X + rightOffset, this.PointB.Y + downOffset);
            this.PointC = new PointF(this.PointC.X + rightOffset, this.PointC.Y + downOffset);
        }

        public override float CalculateArea()
        {
            float area = Math.Abs(
                (this.PointA.X * (this.PointB.Y - this.PointC.Y) +
                 this.PointB.X * (this.PointC.Y - this.PointA.Y) +
                 this.PointC.X * (this.PointA.Y - this.PointB.Y)) / 2);

            return area;
        }
    }
}