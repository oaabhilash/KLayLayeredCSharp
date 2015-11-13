using KLay.Core.KGraph.Interfaces;
using KLay.Kiml.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLay.Core.KGraph.Entities
{
    public class KEdge
    {
        List<KLabel> _labelList = new List<KLabel>();

        public IKNode TargetNode {get; set;}

        public IKNode SourceNode { get; set; }

        public KPort SourcePort { get; set; }
        public KPort TargetPort { get; set; }


        public List<KLabel> LabelList { get { return _labelList; } }

        public IKEdgeLayout EdgeLayout { get; set; }
    }
}
