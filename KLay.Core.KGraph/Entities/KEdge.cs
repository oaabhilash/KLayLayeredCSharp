using KLay.Core.KGraph.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLay.Core.KGraph.Entities
{
    public class KEdge
    {
        public IKNode TargetNode {get; set;}

        public IKNode SourceNode { get; set; }

        public KPort SourcePort { get; set; }
        public KPort TargetPort { get; set; }

    }
}
