using ShapeMaker.Models.Contracts;
using System.Collections.Generic;

namespace ShapeMaker.IO.Contracts
{
    public interface IExporter
    {
        void Export(string path, IList<IShape> shapes);
    }
}
