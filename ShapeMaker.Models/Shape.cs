using ShapeMaker.Models.Contracts;
using System.Drawing;

namespace ShapeMaker.Models
{
    public abstract class Shape : IShape
    {
        protected Color color;

        public Color Color => this.color;

        public int CurrentLayer { get; private set; }

        public Shape(Color color, int currentLayer)
        {
            this.color = color;
            this.CurrentLayer = currentLayer;
        }

        public abstract float CalculateArea();

        public virtual void Draw(Graphics graphics)
        {
        }
        
        public virtual void Move(float rightOffset, float downOffset)
        {
        }

        //ChangesColor
        public void ChangeColor(Color newColor)
        {
            this.color = newColor;
        }

        public virtual void Outline(Graphics graphics, Color color)
        {
        }

        public abstract bool Contains(PointF point);

        //Changes currentLayer
        public void ChangeCurrentLayer(int newLayer)
        {
            this.CurrentLayer = newLayer;
        }
    }
}
