using ShapeMaker.Models;
using ShapeMaker.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

//Github -> https://github.com/GeorgiBarbutov/TU-OOP-ShapeMaker

namespace ShapeMaker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Polymorphysm demo
            //IShape triangle = new Triangle(1, 1, 3, 3, 6, 6, ConsoleColor.Blue);
            //IShape rectangle = new Rectangle(1, 1, 3, 3, 6, 6, -7, -7, ConsoleColor.Blue);
            //IShape circle = new Circle(0, 0, 5, ConsoleColor.DarkBlue);

            //IList<IShape> shapes = new List<IShape>
            //{
            //    triangle,
            //    rectangle,
            //    circle
            //};

            //decimal area = shapes[0].CalculateArea();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Scene scene = new Scene();

            Application.Run(scene);
        }
    }
}
