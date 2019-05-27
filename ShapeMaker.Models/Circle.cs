using ShapeMaker.Models.Contracts;
using System;
using System.Drawing;

namespace ShapeMaker.Models
{
    public class Circle : Shape, ICircle
    {
        public Circle(PointF center, float radius, Color color, int currentLayer) 
            : base(color, currentLayer)
        {
            SetValues(center, radius);
        }

        public PointF Center { get; private set; }

        public float Radius { get; private set; }
        
        public void ChangeSize(PointF center, float radius)
        {
            SetValues(center, radius);
        }

        //Changes properties (same for all other shapes)
        private void SetValues(PointF center, float radius)
        {
            this.Center = center;
            this.Radius = radius;
        }

        //Draws a circle
        public override void Draw(Graphics graphics)
        {
            Brush brush = new SolidBrush(this.color);

            graphics.FillEllipse(brush, this.Center.X - this.Radius, this.Center.Y - this.Radius, 
                this.Radius * 2, this.Radius * 2);

            brush.Dispose();
        }

        //Draws a thin outline on the edge(same for all other shapes)
        public override void Outline(Graphics graphics, Color color)
        {
            Pen pen = new Pen(color, 2);

            graphics.DrawEllipse(pen, this.Center.X - this.Radius, this.Center.Y - this.Radius,
                this.Radius * 2, this.Radius * 2);

            pen.Dispose();
        }

        //Changes coordinates for all points with some right and left offsets(same for all other shapes)
        public override void Move(float rightOffset, float downOffset)
        {
            this.Center = new PointF(this.Center.X + rightOffset, this.Center.Y + downOffset);
        }

        //Calculates the area of the shape depending on some formula(same for all other shapes)
        public override float CalculateArea()
        {
            float area = (float)Math.PI * this.Radius * this.Radius;

            return area;
        }

        //Checks if a point is contained in the shape depending on some formula(same for all other shapes)
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
