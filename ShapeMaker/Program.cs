using ShapeMaker.Contracts;
using ShapeMaker.IO;
using ShapeMaker.IO.Contracts;
using ShapeMaker.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

//Github -> https://github.com/GeorgiBarbutov/TU-OOP-ShapeMaker

namespace ShapeMaker
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            IList<IShape> list = new List<IShape>();
            IShapeFactory shapeFactory = new ShapeFactory();
            IImporter importer = new Importer();
            IExporter exporter = new Exporter();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Scene scene = new Scene(list, shapeFactory, exporter, importer);

            Application.Run(scene);
        }
    }
}
