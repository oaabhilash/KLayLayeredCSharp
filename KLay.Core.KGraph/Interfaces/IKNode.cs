using KLay.Core.KGraph.Entities;
using KLay.Kiml.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLay.Core.KGraph.Interfaces
{
    public interface IKNode
    {
        IKShapeLayout KShapeLayout { get; set; }
        IKNode Parent { get; set; }
        List<KLabel> LabelList { get; }

        List<IKNode> Children { get; }

        List<KPort> PortList { get ;  }
    }

}
