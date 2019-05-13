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

            brush.Dispose();
        }

        public override void Outline(Graphics graphics, Color color)
        {
            Pen pen = new Pen(color, 2);

            graphics.DrawRectangle(pen, this.Point.X, this.Point.Y, this.Width, this.Height);

            pen.Dispose();
        }
        
        public override void Move(float rightOffset, float downOffset)
        {
            this.Point = new PointF(this.Point.X + rightOffset, this.Point.Y + downOffset);
        }

        public override float CalculateArea()
        {
            float area = this.Width * this.Height;

            return area;
        }

        public override bool Contains(PointF point)
        {
            if (point.X >= this.Point.X && point.X <= this.Point.X + this.Width && 
                point.Y >= this.Point.Y && point.Y <= this.Point.Y + this.Height)
            {
                return true;
            }

            return false;
        }
    }
}
