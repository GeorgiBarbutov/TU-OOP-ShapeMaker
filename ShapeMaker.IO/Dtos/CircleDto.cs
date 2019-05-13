using ShapeMaker.IO.Contracts;
using System.Xml.Serialization;

namespace ShapeMaker.IO.Dtos
{
    [XmlType("Circle")]
    public class CircleDto : IShapeDto
    {
        [XmlElement("CenterX")]
        public float CenterX { get; set; }

        [XmlElement("CenterY")]
        public float CenterY { get; set; }

        [XmlElement("Radius")]
        public float Radius { get; set; }

        [XmlElement("Color")]
        public string Color { get; set; }
    }
}
