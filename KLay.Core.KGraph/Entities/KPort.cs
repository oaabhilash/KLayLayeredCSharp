using KLay.Core.KGraph.Interfaces;
using KLay.Kiml.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLay.Core.KGraph.Entities
{
    public class KPort
    {
        List<KLabel> _labelList = new List<KLabel>();
        List<KEdge> _edgeList = new List<KEdge>();
        IKNode _node;

        //TODO :: Add unit test
        public IKNode Node { get { return _node; }
            set {

                if(_node != null)
                {
                    _node.PortList.Remove(this);
                }
                _node = value;
                
                if(_node != null)
                {
                    _node.PortList.Add(this);
                }

            } }

        public IKShapeLayout KShapeLayout { get; set; }

        public List<KLabel> LabelList { get { return _labelList; } }

        public List<KEdge> EdgeList { get { return _edgeList; } }

    }
}
