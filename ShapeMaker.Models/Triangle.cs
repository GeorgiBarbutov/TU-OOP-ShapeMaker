using ShapeMaker.Models.Contracts;
using System;
using System.Drawing;

namespace ShapeMaker.Models
{
    public class Triangle : Shape, ITriangle
    {
        public Triangle(PointF pointA, PointF pointB, PointF pointC, Color color, int currentLayer) 
            : base(color, currentLayer)
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

        //Draws a triangle
        public override void Draw(Graphics graphics)
        {
            Brush brush = new SolidBrush(this.color);
            
            graphics.FillPolygon(brush, new PointF[] { this.PointA, this.PointB, this.PointC });

            brush.Dispose();
        }

        public override void Outline(Graphics graphics, Color color)
        {
            Pen pen = new Pen(color, 2);

            graphics.DrawPolygon(pen, new PointF[] { this.PointA, this.PointB, this.PointC });

            pen.Dispose();
        }
        
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

        public override bool Contains(PointF point)
        {
            float d1 = Sign(point, this.PointA, this.PointB);
            float d2 = Sign(point, this.PointB, this.PointC);
            float d3 = Sign(point, this.PointC, this.PointA);

            bool hasNeg = (d1 < 0) || (d2 < 0) || (d3 < 0);
            bool hasPos = (d1 > 0) || (d2 > 0) || (d3 > 0);

            return !(hasNeg && hasPos);
        }

        private float Sign(PointF point1, PointF point2, PointF point3)
        {
            return (point1.X - point3.X) * (point2.Y - point3.Y) - 
                (point2.X - point3.X) * (point1.Y - point3.Y);
        }
    }
}