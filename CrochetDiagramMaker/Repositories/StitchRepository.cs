using CrochetDiagramMaker.Models.Stitches.Contracts;
using CrochetDiagramMaker.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrochetDiagramMaker.Repositories
{
    public class StitchRepository : IRepository<IStitch>
    {
        private readonly List<IStitch> stitches;

        public StitchRepository()
        {
            stitches = new List<IStitch>();
        }

        public IReadOnlyCollection<IStitch> Models => stitches.AsReadOnly();

        public void Add(IStitch model)
        {
            stitches.Add(model);
        }

        public bool Remove(IStitch model)
        {
            return stitches.Remove(model);
        }
    }
}
