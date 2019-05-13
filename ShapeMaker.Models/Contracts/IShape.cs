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

        /// <summary>
        ///     Changes the coordinates by a specific offset.
        /// </summary>
        /// <param name="rightOffset">
        ///     Positive value will move the figure to the right and negative value will move the figure to the left.
        /// </param>
        /// <param name="downOffset">
        ///     Positive value will move the figure to the down and negative value will move the figure to the up.
        /// </param>
        void Move(float rightOffset, float downOffset);

        void ChangeColor(Color newColor);

        void Outline(Graphics graphics, Color color);
    }
}
