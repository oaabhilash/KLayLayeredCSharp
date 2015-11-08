using KLay.Core.KGraph.Entities;
using KLay.Core.KGraph.Interfaces;
using KLay.Kiml.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLay.Core.KGraph
{
    public class KNode : IKNode
    {
        IKNode _parent;
        List<KLabel> _labelList = new List<KLabel>();

        public IKShapeLayout KShapeLayout { get; set; }

        public IKNode Parent {
            set
            {
                IKNode newParent = value;
                if(newParent.Parent == this)
                {
                    throw new ArgumentException("Recursive Containment is not allowed KNode");
                }
                _parent = newParent;

            }
            get
            {
                return _parent;
            }
        }

        public List<KLabel> LabelList { get { return _labelList; }
                 
    }
}
