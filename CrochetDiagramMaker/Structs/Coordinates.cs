using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrochetDiagramMaker.Structs
{
    public struct Coordinates
    {
        public Coordinates(double top, double left)
        {
            Top = top;
            Left = left;
        }
        public double Top { get; set; }
        public double Left { get; set; }
    }
}
