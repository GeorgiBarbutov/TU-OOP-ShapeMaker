﻿using System.Xml.Serialization;

namespace ShapeMaker.IO.Dtos
{
    [XmlType("Rectangle")]
    public class RectangleDto
    {
        [XmlElement("PointX")]
        public float PointX { get; set; }

        [XmlElement("PointY")]
        public float PointY { get; set; }

        [XmlElement("Width")]
        public float Width { get; set; }

        [XmlElement("Height")]
        public float Height { get; set; }

        [XmlElement("Color")]
        public string Color { get; set; }
    }
}
