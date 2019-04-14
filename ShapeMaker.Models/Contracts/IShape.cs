using System;

namespace ShapeMaker.Models.Contracts
{
    public interface IShape
    {
        void Draw();

        decimal CalculateArea();

        void Move(decimal rightOffset, decimal downOffset);

        void ChangeColor(ConsoleColor newColor);
    }
}
