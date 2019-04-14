using System;

namespace ShapeMaker.Models
{
    public class Circle : Shape
    {
        private decimal center_XCoordinate;
        private decimal center_YCoordinate;
        private decimal radius_Length;

        public Circle(decimal center_XCoordinate, decimal center_YCoordinate,
            decimal radius_Length, ConsoleColor color) : base(color)
        {
            SetValues(center_XCoordinate, center_YCoordinate, radius_Length);
        }

        public void ChangeSize(decimal center_XCoordinate, decimal center_YCoordinate,
           decimal radius_Length)
        {
            SetValues(center_XCoordinate, center_YCoordinate, radius_Length);
        }

        private void SetValues(decimal center_XCoordinate, decimal center_YCoordinate,
           decimal radius_Length)
        {
            this.center_XCoordinate = center_XCoordinate;
            this.center_YCoordinate = center_YCoordinate;
            this.radius_Length = radius_Length;
        }

        public override void Draw()
        {
            base.Draw(); // TODO:
        }

        /// <summary>
        ///     Changes the coordinates by a specific offset.
        /// </summary>
        /// <param name="rightOffset">
        ///     Positive value will move the figure to the right and negative value will move the figure to the left.
        /// </param>
        /// <param name="downOffset">
        ///     Positive value will move the figure to the down and negative value will move the figure to the up.
        /// </param>
        public override void Move(decimal rightOffset, decimal downOffset)
        {
            this.center_XCoordinate += rightOffset;

            this.center_YCoordinate += downOffset;
        }

        public override decimal CalculateArea()
        {
            decimal area = (decimal)(Math.PI * (double)this.radius_Length * (double)this.radius_Length);

            return area;
        }
    }
}
