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
        public IList<IShape> Import(string path, out int currentMaxLayer)
        {
            ShapesDto shapesDto = ImportShapesDtoFromXml(path);

            IList<IShape> shapes = new List<IShape>();

            GetShapesFromDto(shapesDto, shapes);

            //Set the maxLayer to the highest number.
            currentMaxLayer = shapes.OrderByDescending(s => s.CurrentLayer).ToArray()[0].CurrentLayer;

            return shapes;
        }

        //Creates shapes from ShapesDtos and adds them to shapes list
        private static void GetShapesFromDto(ShapesDto shapesDto, IList<IShape> shapes)
        {
            foreach (CircleDto circleDto in shapesDto.Circles)
            {
                PointF center = new PointF(circleDto.CenterX, circleDto.CenterY);

                float radius = circleDto.Radius;

                Color color = GetColor(circleDto);

                int currentLayer = circleDto.CurrentLayer;

                IShape circle = new Circle(center, radius, color, currentLayer);

                shapes.Add(circle);
            }

            foreach (TriangleDto triangleDto in shapesDto.Triangles)
            {
                PointF pointA = new PointF(triangleDto.PointAX, triangleDto.PointAY);
                PointF pointB = new PointF(triangleDto.PointBX, triangleDto.PointBY);
                PointF pointC = new PointF(triangleDto.PointCX, triangleDto.PointCY);

                Color color = GetColor(triangleDto);

                int currentLayer = triangleDto.CurrentLayer;

                IShape triangle = new Triangle(pointA, pointB, pointC, color, currentLayer);

                shapes.Add(triangle);
            }

            foreach (RectangleDto rectangleDto in shapesDto.Rectangles)
            {
                PointF point = new PointF(rectangleDto.PointX, rectangleDto.PointY);

                float height = rectangleDto.Height;
                float width = rectangleDto.Width;

                Color color = GetColor(rectangleDto);

                int currentLayer = rectangleDto.CurrentLayer;

                IShape rectangle = new ShapeMaker.Models.Rectangle(point, width, height, color, currentLayer);

                shapes.Add(rectangle);
            }
        }

        //Uses XmlSerializer to import shapes from Xml file
        private static ShapesDto ImportShapesDtoFromXml(string path)
        {
            XmlRootAttribute rootAttribute = new XmlRootAttribute("Shapes");

            XmlSerializer serializer = new XmlSerializer(typeof(ShapesDto), rootAttribute);

            StreamReader streamReader = new StreamReader(path);

            ShapesDto shapesDto = (ShapesDto)serializer.Deserialize(streamReader);

            streamReader.Dispose();

            return shapesDto;
        }

        //Gets the color
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
