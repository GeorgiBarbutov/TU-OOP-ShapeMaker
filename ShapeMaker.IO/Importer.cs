using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using ShapeMaker.IO.Contracts;
using ShapeMaker.IO.Dtos;
using ShapeMaker.Models;
using ShapeMaker.Models.Contracts;

namespace ShapeMaker.IO
{
    public class Importer : IImporter
    {
        public IList<IShape> Import(string path)
        {
            ShapesDto shapesDto = ImportShapesDtoFromXml(path);

            IList<IShape> shapes = new List<IShape>();

            GetShapesFromDto(shapesDto, shapes);

            return shapes;
        }

        private static void GetShapesFromDto(ShapesDto shapesDto, IList<IShape> shapes)
        {
            foreach (CircleDto circleDto in shapesDto.Circles)
            {
                PointF center = new PointF(circleDto.CenterX, circleDto.CenterY);
                float radius = circleDto.Radius;
                Color color = GetColor(circleDto);

                IShape circle = new Circle(center, radius, color);

                shapes.Add(circle);
            }

            foreach (TriangleDto triangleDto in shapesDto.Triangles)
            {
                PointF pointA = new PointF(triangleDto.PointAX, triangleDto.PointAY);
                PointF pointB = new PointF(triangleDto.PointBX, triangleDto.PointBY);
                PointF pointC = new PointF(triangleDto.PointCX, triangleDto.PointCY);

                Color color = GetColor(triangleDto);

                IShape triangle = new Triangle(pointA, pointB, pointC, color);

                shapes.Add(triangle);
            }

            foreach (RectangleDto rectangleDto in shapesDto.Rectangles)
            {
                PointF point = new PointF(rectangleDto.PointX, rectangleDto.PointY);
                float height = rectangleDto.Height;
                float width = rectangleDto.Width;
                Color color = GetColor(rectangleDto);

                IShape rectangle = new ShapeMaker.Models.Rectangle(point, width, height, color);

                shapes.Add(rectangle);
            }
        }

        private static ShapesDto ImportShapesDtoFromXml(string path)
        {
            XmlRootAttribute rootAttribute = new XmlRootAttribute("Shapes");

            XmlSerializer serializer = new XmlSerializer(typeof(ShapesDto), rootAttribute);

            StreamReader streamReader = new StreamReader(path);

            ShapesDto shapesDto = (ShapesDto)serializer.Deserialize(streamReader);

            streamReader.Dispose();

            return shapesDto;
        }

        private static Color GetColor(IShapeDto shapeDto)
        {
            string colorArgument = shapeDto.Color.Split('[')[1].Split(']')[0];

            Color color;

            if(colorArgument.Split(' ').Length == 1)
            {
                //Color [Black] -> Black
                string knownColorName = shapeDto.Color.Split(' ')[1]
                    .Substring(1, shapeDto.Color.Split(' ')[1].Length - 2);

                color = Color.FromName(knownColorName);
            }
            else
            {
                //Color [A=255, R=91, G=140, B=131] -> [] { 255, 91, 140, 131 }
                int[] argbParameters = shapeDto.Color.Split('[')[1]
                    .Split(']')[0]
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => int.Parse(s.Split('=')[1]))
                    .ToArray();

                color = Color.FromArgb(argbParameters[0], argbParameters[1], argbParameters[2],
                    argbParameters[3]);
            }

            return color;
        }
    }
}
