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
    public partial class Scene : Form
    {
        private Color SELECTED_FIGURE_OUTLINE_COLOR = Color.IndianRed;

        private IList<IShape> shapes;
        private IShapeFactory shapeFactory;
        private IShape selectedFigure;

        public Scene(IList<IShape> shapes, IShapeFactory shapeFactory)
        {
            InitializeComponent();

            this.shapes = shapes;
            this.shapeFactory = shapeFactory;
        }

        private void addShapeButton_Click(object sender, EventArgs e)
        {
            AddShape addShapeForm = new AddShape(this.shapeFactory);
            addShapeForm.ShowDialog();

            Graphics graphics = this.canvas.CreateGraphics();

            if (addShapeForm.Shape != null)
            {
                IShape newShape = addShapeForm.Shape;

                this.shapes.Add(newShape);

                newShape.Draw(graphics);

                float areaTaken = newShape.CalculateArea();
                this.NewShapeAreaNumber.Text = $"{areaTaken:f1}";

                float totalAreaTaken = this.shapes.Sum(s => s.CalculateArea());
                this.TotalAreaTakenNumber.Text = $"{totalAreaTaken:f1}";
            }

            graphics.Dispose();
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            PointF cursorPosition = new PointF(e.X, e.Y);

            Graphics graphics = this.canvas.CreateGraphics();

            foreach (IShape shape in shapes)
            {
                bool isInside = shape.Contains(cursorPosition);

                if (isInside)
                {
                    if (this.selectedFigure != null)
                    {
                        this.selectedFigure.Outline(graphics, this.selectedFigure.Color);
                    }

                    this.selectedFigure = shape;

                    this.selectedFigure.Outline(graphics, SELECTED_FIGURE_OUTLINE_COLOR);

                    break;
                }
            }

            graphics.Dispose();
        }

        private void EditShapeButton_Click(object sender, EventArgs e)
        {
            if (this.selectedFigure != null)
            {
                EditShape editShapeForm = new EditShape(this.selectedFigure);
                editShapeForm.ShowDialog();
                
                RedrawCanvas();
            }
        }

        private void RedrawCanvas()
        {
            this.canvas.Refresh();

            Graphics graphics = this.canvas.CreateGraphics();

            foreach (IShape shape in this.shapes)
            {
                shape.Draw(graphics);
            }

            graphics.Dispose();
        }

        private void removeShapeButton_Click(object sender, EventArgs e)
        {
            this.shapes.Remove(this.selectedFigure);

            this.selectedFigure = null;

            RedrawCanvas();

            this.NewShapeAreaNumber.Text = "0.0";

            float totalAreaTaken = this.shapes.Sum(s => s.CalculateArea());
            this.TotalAreaTakenNumber.Text = $"{totalAreaTaken:f1}";
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            //TODO:Drag a shape to move
        }
    }
}
