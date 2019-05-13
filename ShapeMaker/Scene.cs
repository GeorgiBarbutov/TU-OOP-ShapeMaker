using ShapeMaker.Contracts;
using ShapeMaker.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ShapeMaker.IO.Contracts;
using ShapeMaker.IO;

namespace ShapeMaker
{
    public partial class Scene : Form
    {
        private Color SELECTED_FIGURE_OUTLINE_COLOR = Color.IndianRed;

        private IList<IShape> shapes;
        private IShapeFactory shapeFactory;
        private IShape selectedFigure;
        private float mouseDownXCoordinate;
        private float mouseDownYCoordinate;

        public Scene(IList<IShape> shapes, IShapeFactory shapeFactory)
        {
            InitializeComponent();

            this.shapes = shapes;
            this.shapeFactory = shapeFactory;
        }

        private void AddShapeButton_Click(object sender, EventArgs e)
        {
            AddShape addShapeForm = new AddShape(this.shapeFactory);
            addShapeForm.ShowDialog();

            Graphics graphics = this.Canvas.CreateGraphics();

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
            this.Canvas.Refresh();

            Graphics graphics = this.Canvas.CreateGraphics();

            foreach (IShape shape in this.shapes)
            {
                shape.Draw(graphics);
            }

            graphics.Dispose();
        }

        private void RemoveShapeButton_Click(object sender, EventArgs e)
        {
            this.shapes.Remove(this.selectedFigure);

            this.selectedFigure = null;

            RedrawCanvas();

            this.NewShapeAreaNumber.Text = "0.0";

            float totalAreaTaken = this.shapes.Sum(s => s.CalculateArea());
            this.TotalAreaTakenNumber.Text = $"{totalAreaTaken:f1}";
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDownXCoordinate = e.X;
            this.mouseDownYCoordinate = e.Y;

            if(e.Button == MouseButtons.Left)
            {
                PointF cursorPosition = new PointF(e.X, e.Y);

                Graphics graphics = this.Canvas.CreateGraphics();

                if (this.selectedFigure != null)
                {
                    this.selectedFigure.Outline(graphics, this.selectedFigure.Color);
                }

                bool cursorIsOnAnyShape = false;

                foreach (IShape shape in shapes)
                {
                    bool isInside = shape.Contains(cursorPosition);

                    if (isInside)
                    {
                        this.selectedFigure = shape;

                        cursorIsOnAnyShape = true;

                        break;
                    }
                }

                if(!cursorIsOnAnyShape)
                {
                    this.selectedFigure = null;
                }

                graphics.Dispose();
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(this.selectedFigure != null && e.Button == MouseButtons.Left)
            {
                this.selectedFigure.Move(e.X - this.mouseDownXCoordinate, e.Y - this.mouseDownYCoordinate);

                RedrawCanvas();

                this.mouseDownXCoordinate = e.X;
                this.mouseDownYCoordinate = e.Y;
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics graphics = Canvas.CreateGraphics();

            if(this.selectedFigure != null)
            {
                this.selectedFigure.Outline(graphics, SELECTED_FIGURE_OUTLINE_COLOR);
            }

            graphics.Dispose();
        }

        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = $"{Environment.CurrentDirectory}",
                Filter = "XML (*.xml)|*.xml"
            };

            saveFileDialog.ShowDialog();

            string path = saveFileDialog.FileName;

            IExporter exporter = new Exporter(shapes);
            exporter.Export(path);

            saveFileDialog.Dispose();
        }
    }
}
