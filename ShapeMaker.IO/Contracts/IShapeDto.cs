using System.Xml.Serialization;

namespace ShapeMaker.IO.Contracts
{
    public interface IShapeDto
    {
        string Color { get; set; }

        int CurrentLayer { get; set; }
    }
}
