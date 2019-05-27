using ShapeMaker.Models.Contracts;
using System.Collections.Generic;

namespace ShapeMaker.IO.Contracts
{
    public interface IImporter
    {
        IList<IShape> Import(string path, out int currentMaxLayer);
    }
}
