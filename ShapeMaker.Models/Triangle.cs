using System;

namespace ShapeMaker.Models
{
    public class Triangle : Shape
    {
        private decimal pointA_XCoordinate;
        private decimal pointA_YCoordinate;
        private decimal pointB_XCoordinate;
        private decimal pointB_YCoordinate;
        private decimal pointC_XCoordinate;
        private decimal pointC_YCoordinate;

        public Triangle(decimal pointA_XCoordinate, decimal pointA_YCoordinate,
            decimal pointB_XCoordinate, decimal pointB_YCoordinate, decimal pointC_XCoordinate,
            decimal pointC_YCoordinate, ConsoleColor color) : base(color)
        {
            SetValues(pointA_XCoordinate, pointA_YCoordinate, pointB_XCoordinate, pointB_YCoordinate,
                pointC_XCoordinate, pointC_YCoordinate);
        }
        
        public void ChangeSize(decimal pointA_XCoordinate, decimal pointA_YCoordinate, 
            decimal pointB_XCoordinate, decimal pointB_YCoordinate, decimal pointC_XCoordinate, 
            decimal pointC_YCoordinate)
        {
            SetValues(pointA_XCoordinate, pointA_YCoordinate, pointB_XCoordinate, pointB_YCoordinate,
                pointC_XCoordinate, pointC_YCoordinate);
        }

        private void SetValues(decimal pointA_XCoordinate, decimal pointA_YCoordinate,
            decimal pointB_XCoordinate, decimal pointB_YCoordinate, decimal pointC_XCoordinate,
            decimal pointC_YCoordinate)
        {
            this.pointA_XCoordinate = pointA_XCoordinate;
            this.pointA_YCoordinate = pointA_YCoordinate;
            this.pointB_XCoordinate = pointB_XCoordinate;
            this.pointB_YCoordinate = pointB_YCoordinate;
            this.pointC_XCoordinate = pointC_XCoordinate;
            this.pointC_YCoordinate = pointC_YCoordinate;
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
            this.pointA_XCoordinate += rightOffset;
            this.pointB_XCoordinate += rightOffset;
            this.pointC_XCoordinate += rightOffset;

            this.pointA_YCoordinate += downOffset;
            this.pointB_YCoordinate += downOffset;
            this.pointC_YCoordinate += downOffset;
        }

        public override decimal CalculateArea()
        {
            decimal area = Math.Abs(
                (this.pointA_XCoordinate * (this.pointB_YCoordinate - this.pointC_YCoordinate) +
                 this.pointB_XCoordinate * (this.pointC_YCoordinate - this.pointA_YCoordinate) +
                 this.pointC_XCoordinate * (this.pointA_YCoordinate - this.pointB_YCoordinate)) / 2);

            return area;
        }
    }
}