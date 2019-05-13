using System.Collections.Generic;
using System.Xml.Serialization;

namespace ShapeMaker.IO.Dtos
{
    [XmlRoot("Shapes")]
    public class ShapesDto
    {
        [XmlArray("Circles")]
        public List<CircleDto> Circles { get; set; }

        [XmlArray("Rectangles")]
        public List<RectangleDto> Rectangles { get; set; }

        [XmlArray("Triangles")]
        public List<TriangleDto> Triangles { get; set; }
    }
}
