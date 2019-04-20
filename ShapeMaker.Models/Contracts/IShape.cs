using System;
using System.Drawing;

namespace ShapeMaker.Models.Contracts
{
    public interface IShape
    {
        void Draw(Graphics graphics);

        float CalculateArea();

        void Move(float rightOffset, float downOffset);

        void ChangeColor(Color newColor);
    }
}
