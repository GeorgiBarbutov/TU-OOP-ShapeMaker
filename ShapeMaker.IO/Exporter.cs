using ShapeMaker.IO.Contracts;
using ShapeMaker.IO.Dtos;
using ShapeMaker.Models.Contracts;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace ShapeMaker.IO
{
    public class Exporter : IExporter
    {
        private IList<IShape> shapes;

        public void Export(string path, IList<IShape> shapes)
        {
            this.shapes = shapes;

            ShapesDto dtos = GetDtos();

            ExportToXml(path, dtos);
        }

        //Uses XmlSerializer to export shapeDtos to xml file
        private static void ExportToXml(string path, ShapesDto dtos)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ShapesDto), new XmlRootAttribute("Shapes"));

            StreamWriter streamWriter = new StreamWriter(path);

            serializer.Serialize(streamWriter, dtos);

            streamWriter.Dispose();
        }

        //Changes shapes to ShapesDtos
        private ShapesDto GetDtos()
        {
            return new ShapesDto
            {
                Circles = shapes.Where(shape => shape.GetType().Name == "Circle").Select(c => new CircleDto
                {
                    CenterX = ((ICircle)c).Center.X,
                    CenterY = ((ICircle)c).Center.Y,
                    Radius = ((ICircle)c).Radius,
                    Color = c.Color.ToString(),
                    CurrentLayer = c.CurrentLayer
                }).ToList(),
                Rectangles = shapes.Where(shape => shape.GetType().Name == "Rectangle").Select(r => new RectangleDto
                {
                    PointX = ((IRectangle)r).Point.X,
                    PointY = ((IRectangle)r).Point.Y,
                    Height = ((IRectangle)r).Height,
                    Width = ((IRectangle)r).Width,
                    Color = r.Color.ToString(),
                    CurrentLayer = r.CurrentLayer
                }).ToList(),
                Triangles = shapes.Where(shape => shape.GetType().Name == "Triangle").Select(t => new TriangleDto
                {
                    PointAX = ((ITriangle)t).PointA.X,
                    PointAY = ((ITriangle)t).PointA.Y,
                    PointBX = ((ITriangle)t).PointB.X,
                    PointBY = ((ITriangle)t).PointB.Y,
                    PointCX = ((ITriangle)t).PointC.X,
                    PointCY = ((ITriangle)t).PointC.Y,
                    Color = t.Color.ToString(),
                    CurrentLayer = t.CurrentLayer
                }).ToList()
            };
        }
    }
}
