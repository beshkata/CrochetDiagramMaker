using CrochetDiagramMaker.Models.Stitches.Contracts;
using CrochetDiagramMaker.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrochetDiagramMaker.Models.Stitches
{
    public abstract class Stitch : IStitch
    {

        public Stitch(double top, double left)
        {
            Coordinates = new Coordinates(top, left);

        }
        public Coordinates Coordinates { get; set; }
    }
}
