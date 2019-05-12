using ShapeMaker.Contracts;
using ShapeMaker.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeMaker
{
    public partial class AddShape : Form
    {
        private static Color DEFAULT_SHAPE_COLOR = Color.Black;

        IShapeFactory shapeFactory;

        public AddShape(IShapeFactory shapeFactory)
        {
            InitializeComponent();
            
            this.shapeFactory = shapeFactory;
            this.ShapeColorSelected.BackColor = DEFAULT_SHAPE_COLOR;
        }

        public IShape Shape { get; private set; }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TriangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTriangleOptionsVisibility(true);
            ChangeRectangleOptionsVisibility(false);
            ChangeCircleOptionsVisibility(false);
        }

        private void RectangleButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTriangleOptionsVisibility(false);
            ChangeRectangleOptionsVisibility(true);
            ChangeCircleOptionsVisibility(false);
        }

        private void CircleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTriangleOptionsVisibility(false);
            ChangeRectangleOptionsVisibility(false);
            ChangeCircleOptionsVisibility(true);
        }

        private void ChangeCircleOptionsVisibility(bool isVisible)
        {
            this.CenterXLabel.Visible = isVisible;
            this.CenterXNumber.Visible = isVisible;
            this.CenterYLabel.Visible = isVisible;
            this.CenterYNumber.Visible = isVisible;
            this.RadiusLabel.Visible = isVisible;
            this.RadiusNumber.Visible = isVisible;
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
        }

        private void AddShapeButton_Click(object sender, EventArgs e)
        {
            if(this.TriangleRadioButton.Checked)
            {
                this.Shape = this.shapeFactory.CreateTriangle((float)this.PointAXCoordinateNumber.Value,
                    (float)this.PointAYCoordinateNumber.Value, (float)this.PointBXCoordinateNumber.Value,
                    (float)this.PointBYCoordinateNumber.Value, (float)this.PointCXCoordinateNumber.Value,
                    (float)this.PointCYCoordinateNumber.Value, this.ShapeColorSelected.BackColor);
            }
            else if(this.RectangleRadioButton.Checked)
            {
                this.Shape = this.shapeFactory.CreateRectangle((float)this.PointXNumber.Value,
                    (float)this.PointYNumber.Value, (float)this.WidthNumber.Value,
                    (float)this.HeightNumber.Value,  this.ShapeColorSelected.BackColor);
            }
            else
            {
                this.Shape = this.shapeFactory.CreateCicle( (float)this.CenterXNumber.Value,
                    (float)this.CenterYNumber.Value, (float)this.RadiusNumber.Value,
                    this.ShapeColorSelected.BackColor);
            }
            this.Close();
        }

        private void SelectColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            colorDialog.ShowDialog();

            this.ShapeColorSelected.BackColor = colorDialog.Color;
        }
    }
}
