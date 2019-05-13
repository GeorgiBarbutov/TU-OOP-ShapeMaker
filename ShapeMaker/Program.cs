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
            List<IShape> list = new List<IShape>();
            ShapeFactory shapeFactory = new ShapeFactory();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Scene scene = new Scene(list, shapeFactory);

            Application.Run(scene);
        }
    }
}
