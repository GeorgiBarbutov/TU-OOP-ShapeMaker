using System.Xml.Serialization;

namespace ShapeMaker.IO.Dtos
{
    [XmlType("Triangle")]
    public class TriangleDto
    {
        [XmlElement("PointAX")]
        public float PointAX { get; set; }

        [XmlElement("PointAY")]
        public float PointAY { get; set; }

        [XmlElement("PointBX")]
        public float PointBX { get; set; }

        [XmlElement("PointBY")]
        public float PointBY { get; set; }

        [XmlElement("PointCX")]
        public float PointCX { get; set; }

        [XmlElement("PointCY")]
        public float PointCY { get; set; }

        [XmlElement("Color")]
        public string Color { get; set; }
    }
}
