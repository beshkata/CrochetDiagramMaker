using CrochetDiagramMaker.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrochetDiagramMaker.Models.Stitches.Contracts
{
    public interface IStitch
    {
        Coordinates Coordinates { get; set; }

    }
}
