using System;
using System.Drawing;

namespace ShapeMaker.Models.Contracts
{
    public interface IShape
    {
        Color Color { get; }

        void Draw(Graphics graphics);

        float CalculateArea();
        
        bool Contains(PointF point);

        void Move(float rightOffset, float downOffset);

        void ChangeColor(Color newColor);

        void Outline(Graphics graphics, Color color);
    }
}
