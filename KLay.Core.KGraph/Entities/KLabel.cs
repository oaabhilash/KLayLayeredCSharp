using KLay.Core.KGraph.Interfaces;
using KLay.Kiml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLay.Core.KGraph.Entities
{
    public class KLabel
    {
        string _text = null;
        IKNode _parent = null;
        public KShapeLayout KShapeLayout { get; set; }

        public string Text {
              get { return _text; }
              set { _text = value; } 
        }

        public IKNode Parent {
            get { return _parent; }
            set
            {
                if(_parent != null)
                {
                    
                    _parent.LabelList.Remove(this);
                }
                _parent = value;

                if (_parent != null)
                {
                    _parent.LabelList.Add(this);
                }
            }
        }
    }
}
