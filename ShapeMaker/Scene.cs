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
        private IList<IShape> shapes;
        private IShapeFactory shapeFactory;

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

            addShapeForm.Shape.Draw(graphics);
        }

        public void AddShape(IShape shape)
        {
            Graphics graphics = this.canvas.CreateGraphics();

            shape.Draw(graphics);
        }
    }
}
