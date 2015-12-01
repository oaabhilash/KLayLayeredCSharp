using KLay.Core.KGraph.Entities;
using KLay.Kiml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLay.Core.KGraph.Interfaces
{
    public interface IKNode
    {
        KShapeLayout KShapeLayout { get; set; }
        IKNode Parent { get; set; }
        List<KLabel> LabelList { get; }

        List<IKNode> Children { get; }

        List<KPort> PortList { get ;  }
    }

}
