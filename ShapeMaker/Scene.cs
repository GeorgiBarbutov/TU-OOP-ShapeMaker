using ShapeMaker.Contracts;
using ShapeMaker.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ShapeMaker.IO.Contracts;

namespace ShapeMaker
{
    public partial class Scene : Form
    {
        private const int DEFAULT_CURRENT_MAX_LAYER = 0;

        private IList<IShape> shapes;
        private IShapeFactory shapeFactory;
        private IShape selectedShape;
        private float mouseDownXCoordinate;
        private float mouseDownYCoordinate;
        private IExporter exporter;
        private IImporter importer;
        private int currentMaxLayer;
        private Graphics graphics;

        public Scene(IList<IShape> shapes, IShapeFactory shapeFactory, IExporter exporter, IImporter importer)
        {
            InitializeComponent();

            this.shapes = shapes;
            this.shapeFactory = shapeFactory;
            this.exporter = exporter;
            this.importer = importer;
            this.graphics = this.Canvas.CreateGraphics();

            this.currentMaxLayer = DEFAULT_CURRENT_MAX_LAYER;
        }

        //Opens AddShape Form. Gets the new Shape. Adds it to shapes. Sets selectedShapeArea to 0.0
        private void AddShapeButton_Click(object sender, EventArgs e)
        {
            this.currentMaxLayer += 1;

            AddShape addShapeForm = new AddShape(this.shapeFactory, this.currentMaxLayer);
            addShapeForm.ShowDialog();

            if (addShapeForm.Shape != null)
            {
                IShape newShape = addShapeForm.Shape;

                this.shapes.Add(newShape);

                this.selectedShape = null;
                this.SelectedShapeAreaNumber.Text = "0.0";

                RedrawCanvas();
            }

            addShapeForm.Dispose();
        }

        //Opens EditShapeForm to edit shape and than redraws the canvas.
        private void EditShapeButton_Click(object sender, EventArgs e)
        {
            if (this.selectedShape != null)
            {
                EditShape editShapeForm = new EditShape(this.selectedShape);
                editShapeForm.ShowDialog();
                
                RedrawCanvas();

                editShapeForm.Dispose();
            }
        }

        //Clears the canvas than draws each figure startting from the lowes layer. Sets totalAreaTaken.
        //Keeps selected figure outline.
        private void RedrawCanvas()
        {
            this.Canvas.Refresh();

            foreach (IShape shape in this.shapes.OrderBy(s => s.CurrentLayer))
            {
                shape.Draw(this.graphics);
            }

            float totalAreaTaken = this.shapes.Sum(s => s.CalculateArea());
            this.TotalAreaTakenNumber.Text = $"{totalAreaTaken:f1}";

            if(this.selectedShape != null)
            {
                this.selectedShape.Outline(this.graphics, Color.IndianRed);

                this.SelectedShapeAreaNumber.Text = $"{this.selectedShape.CalculateArea():f1}";
            }
        }

        private void RemoveShapeButton_Click(object sender, EventArgs e)
        {
            this.shapes.Remove(this.selectedShape);

            this.selectedShape = null;
            this.SelectedShapeAreaNumber.Text = "0.0";

            RedrawCanvas();
        }

        //Sets mouse x and y coordinates. Gets cursor position. Removes ouline of the selected shape if any.
        //Tries to find if cursor is inside a shape when clicked. 
        //If its not - deselectes selected shape if any and sets selected area to 0.0
        //If it is - sets new selected shape. Sets selected shape area. Increaces current max layer and sets shape layer
        //And draws shape.
        //Note: always selects the top most shape even if 2 or more shapes are on top of one another
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDownXCoordinate = e.X;
            this.mouseDownYCoordinate = e.Y;

            if(e.Button == MouseButtons.Left)
            {
                PointF cursorPosition = new PointF(e.X, e.Y);

                if (this.selectedShape != null)
                {
                    this.selectedShape.Outline(this.graphics, this.selectedShape.Color);
                }

                bool cursorIsOnAnyShape = false;

                foreach (IShape shape in shapes.OrderByDescending(s => s.CurrentLayer))
                {
                    bool isInside = shape.Contains(cursorPosition);

                    if (isInside)
                    {
                        this.currentMaxLayer += 1;

                        this.selectedShape = shape;
                        this.SelectedShapeAreaNumber.Text = $"{selectedShape.CalculateArea():f1}";

                        this.selectedShape.ChangeCurrentLayer(this.currentMaxLayer);

                        this.selectedShape.Draw(this.graphics);

                        cursorIsOnAnyShape = true;
                        
                        break;
                    }
                }

                if(!cursorIsOnAnyShape)
                {
                    this.selectedShape = null;
                    this.SelectedShapeAreaNumber.Text = "0.0";
                }
            }
        }

        //If any shape is selected and left mouse button is pressed -> 
        //Changes shape coordinates and redraws canvas.
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(this.selectedShape != null && e.Button == MouseButtons.Left)
            {
                this.selectedShape.Move(e.X - this.mouseDownXCoordinate, e.Y - this.mouseDownYCoordinate);

                RedrawCanvas();

                this.mouseDownXCoordinate = e.X;
                this.mouseDownYCoordinate = e.Y;
            }
        }

        //Draws outline for selected shape if any
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if(this.selectedShape != null)
            {
                this.selectedShape.Outline(this.graphics, Color.IndianRed);
            }
        }

        //Opens SaveFileDialog and saves shapes as xml file.
        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = $"{Environment.CurrentDirectory}",
                Filter = "XML (*.xml)|*.xml"
            };

            DialogResult dialogResult = saveFileDialog.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;

                this.exporter.Export(path, shapes);
            }

            saveFileDialog.Dispose();
        }

        //Opens OpenFileDialog and loads shapes from xml file than deselects selected figure and redraws canvas
        private void LoadFromFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = $"{Environment.CurrentDirectory}",
                Filter = "XML (*.xml)|*.xml"
            };

            DialogResult dialogResult = openFileDialog.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                string path = openFileDialog.FileName;

                this.shapes = this.importer.Import(path, out this.currentMaxLayer);

                this.selectedShape = null;
                this.SelectedShapeAreaNumber.Text = "0.0";

                RedrawCanvas();
            }

            openFileDialog.Dispose();
        }
    }
}
