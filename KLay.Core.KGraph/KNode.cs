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
        List<IKNode> _children = new List<IKNode>();

        public IKShapeLayout KShapeLayout { get; set; }

        public IKNode Parent {
            set
            {
                if(_parent != null)
                {
                    _parent.Children.Remove(this);
                }
                
                IKNode newParent = value;
                if(newParent != null && newParent.Parent == this)
                {
                    throw new ArgumentException("Recursive Containment is not allowed KNode");
                }


                _parent = newParent;
                if (_parent != null)
                {
                    _parent.Children.Add(this);
                }
                
            }
            get
            {
                return _parent;
            }
        }

        public List<KLabel> LabelList { get { return _labelList; } }

        public List<IKNode> Children { get { return _children; } }

    }
}
