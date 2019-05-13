using ShapeMaker.Models.Contracts;
using System.Drawing;

namespace ShapeMaker.Models
{
    public abstract class Shape : IShape
    {
        protected Color color;

        public Color Color => this.color;

        public Shape(Color color)
        {
            this.color = color;
        }

        public abstract float CalculateArea();

        public virtual void Draw(Graphics graphics)
        {
        }
        
        public virtual void Move(float rightOffset, float downOffset)
        {
        }

        public void ChangeColor(Color newColor)
        {
            this.color = newColor;
        }

        public virtual void Outline(Graphics graphics, Color color)
        {
        }

        public abstract bool Contains(PointF point);
    }
}
