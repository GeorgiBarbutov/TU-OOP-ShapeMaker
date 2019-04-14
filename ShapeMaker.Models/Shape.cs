using ShapeMaker.Models.Contracts;
using System;

namespace ShapeMaker.Models
{
    public abstract class Shape : IShape
    {
        protected ConsoleColor color;

        public Shape(ConsoleColor color)
        {
            this.color = color;
        }
        
        public void ChangeColor(ConsoleColor newColor)
        {
            this.color = newColor;
        }

        public abstract decimal CalculateArea();

        public virtual void Draw()
        {
        }

        public virtual void Move(decimal rightOffset, decimal downOffset)
        {
        }
    }
}
