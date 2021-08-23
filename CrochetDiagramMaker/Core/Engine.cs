using CrochetDiagramMaker.Core.Contracts;
using CrochetDiagramMaker.Models.Stitches;
using CrochetDiagramMaker.Models.Stitches.Contracts;
using CrochetDiagramMaker.Renderers.Contracts;
using CrochetDiagramMaker.Repositories;
using CrochetDiagramMaker.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrochetDiagramMaker.Core
{
    public class Engine : IEngine
    {
        IRenderer renderer;
        IRepository<IStitch> repository;
        public Engine(IRenderer renderer)
        {
            this.renderer = renderer;
            repository = new StitchRepository();
        }
        public void Run()
        {
            throw new NotImplementedException();
        }

        public void CreateAndDrawNewStich(double top, double left)
        {
            IStitch stitch = new RectangleStitch(top, left);
            renderer.Draw(stitch);
        }
    }
}
