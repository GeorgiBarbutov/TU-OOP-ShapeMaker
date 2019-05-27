using ShapeMaker.Models.Contracts;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShapeMaker
{
    public partial class EditShape : Form
    {
        private static Color DEFAULT_SHAPE_COLOR = Color.Black;

        private Color newColor;

        public EditShape(IShape shape)
        {
            InitializeComponent();

            this.Shape = shape;

            this.ShapeColorSelected.BackColor = Shape.Color;
            this.newColor = Shape.Color;

            SetUpEditOptions();
        }

        public IShape Shape { get; private set; }

        //Changes visual setings depending on selected shape radio button
        private void SetUpEditOptions()
        {
            if(this.Shape.GetType().Name == "Triangle")
            {
                ChangeCircleOptionsVisibility(false);
                ChangeRectangleOptionsVisibility(false);
                ChangeTriangleOptionsVisibility(true);

                this.FigureLabel.Text = "Triangle";
            }
            else if(this.Shape.GetType().Name == "Rectangle")
            {
                ChangeCircleOptionsVisibility(false);
                ChangeRectangleOptionsVisibility(true);
                ChangeTriangleOptionsVisibility(false);

                this.FigureLabel.Text = "Rectangle";
            }
            else if (this.Shape.GetType().Name == "Circle")
            {
                ChangeCircleOptionsVisibility(true);
                ChangeRectangleOptionsVisibility(false);
                ChangeTriangleOptionsVisibility(false);

                this.FigureLabel.Text = "Circle";
            }
        }

        private void ChangeCircleOptionsVisibility(bool isVisible)
        {
            this.CenterXLabel.Visible = isVisible;
            this.CenterXNumber.Visible = isVisible;
            this.CenterYLabel.Visible = isVisible;
            this.CenterYNumber.Visible = isVisible;
            this.RadiusLabel.Visible = isVisible;
            this.RadiusNumber.Visible = isVisible;
            
            if(isVisible)
            {
                ICircle circle = (ICircle)this.Shape;

                this.CenterXNumber.Value = (decimal)circle.Center.X;
                this.CenterYNumber.Value = (decimal)circle.Center.Y;
                this.RadiusNumber.Value = (decimal)circle.Radius;
            }
        }

        private void ChangeRectangleOptionsVisibility(bool isVisible)
        {
            this.PointXLabel.Visible = isVisible;
            this.PointXNumber.Visible = isVisible;
            this.PointYLabel.Visible = isVisible;
            this.PointYNumber.Visible = isVisible;
            this.WidthLabel.Visible = isVisible;
            this.WidthNumber.Visible = isVisible;
            this.HeightLabel.Visible = isVisible;
            this.HeightNumber.Visible = isVisible;

            if (isVisible)
            {
                IRectangle rectangle = (IRectangle)this.Shape;

                this.PointXNumber.Value = (decimal)rectangle.Point.X;
                this.PointYNumber.Value = (decimal)rectangle.Point.Y;
                this.WidthNumber.Value = (decimal)rectangle.Width;
                this.HeightNumber.Value = (decimal)rectangle.Height;
            }
        }

        private void ChangeTriangleOptionsVisibility(bool isVisible)
        {
            this.PointAXCoordinateLabel.Visible = isVisible;
            this.PointAXCoordinateNumber.Visible = isVisible;
            this.PointAYCoordinateLabel.Visible = isVisible;
            this.PointAYCoordinateNumber.Visible = isVisible;
            this.PointBXCoordinateLabel.Visible = isVisible;
            this.PointBXCoordinateNumber.Visible = isVisible;
            this.PointBYCoordinateLabel.Visible = isVisible;
            this.PointBYCoordinateNumber.Visible = isVisible;
            this.PointCXCoordinateLabel.Visible = isVisible;
            this.PointCXCoordinateNumber.Visible = isVisible;
            this.PointCYCoordinateLabel.Visible = isVisible;
            this.PointCYCoordinateNumber.Visible = isVisible;

            if (isVisible)
            {
                ITriangle triangle = (ITriangle)this.Shape;

                this.PointAXCoordinateNumber.Value = (decimal)triangle.PointA.X;
                this.PointAYCoordinateNumber.Value = (decimal)triangle.PointA.Y;
                this.PointBXCoordinateNumber.Value = (decimal)triangle.PointB.X;
                this.PointBYCoordinateNumber.Value = (decimal)triangle.PointB.Y;
                this.PointCXCoordinateNumber.Value = (decimal)triangle.PointC.X;
                this.PointCYCoordinateNumber.Value = (decimal)triangle.PointC.Y;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Opens ColorDialog and selects color
        private void SelectColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            colorDialog.ShowDialog();

            this.ShapeColorSelected.BackColor = colorDialog.Color;

            this.newColor = colorDialog.Color;

            colorDialog.Dispose();
        }

        //Saves updated properties depending on shape type and closes form.
        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if(this.Shape.GetType().Name == "Circle")
            {
                ICircle circle = (ICircle)this.Shape;

                circle.ChangeSize(new PointF((float)this.CenterXNumber.Value, (float)this.CenterYNumber.Value),
                    (float)this.RadiusNumber.Value);
            }
            else if (this.Shape.GetType().Name == "Rectangle")
            {
                IRectangle rectangle = (IRectangle)this.Shape;

                rectangle.ChangeSize(new PointF((float)this.PointXNumber.Value, (float)this.PointYNumber.Value),
                    (float)this.WidthNumber.Value, (float)this.HeightNumber.Value);
            }
            else if (this.Shape.GetType().Name == "Triangle")
            {
                ITriangle triangle = (ITriangle)this.Shape;

                triangle.ChangeSize(
                    new PointF((float)this.PointAXCoordinateNumber.Value, (float)this.PointAYCoordinateNumber.Value),
                    new PointF((float)this.PointBXCoordinateNumber.Value, (float)this.PointBYCoordinateNumber.Value),
                    new PointF((float)this.PointCXCoordinateNumber.Value, (float)this.PointCYCoordinateNumber.Value));
            }

            this.Shape.ChangeColor(this.newColor);

            this.Close();
        }
    }
}
