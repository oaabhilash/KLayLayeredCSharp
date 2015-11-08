using KLay.Core.KGraph.Interfaces;
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
        public IKNode _parent = null;

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
                    //TODO :: will need to add unit test to confirm this works
                    _parent.LabelList.Remove(this);
                    _parent = value;
                    _parent.LabelList.Add(this);
                }
            }
        }
    }
}
