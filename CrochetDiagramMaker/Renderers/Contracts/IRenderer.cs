using CrochetDiagramMaker.Models.Stitches.Contracts;
using CrochetDiagramMaker.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrochetDiagramMaker.Renderers.Contracts
{
    public interface IRenderer
    {
        void DrawAll(ICollection<IStitch> stitches);

        void Draw(IStitch stitch);

        void Clear(IStitch stitch);

        void ClearAll(ICollection<IStitch> stitches);
    }
}
