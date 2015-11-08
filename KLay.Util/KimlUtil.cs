using KLay.Core.KGraph;
using KLay.Core.KGraph.Interfaces;
using KLay.Kiml;
using KLay.Kiml.Interfaces;
using KLay.Util.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLay.Util
{
    public class KimlUtil : IKimlUtil
    {
        public IKNode CreateInitializedKNode()
        {
            IKNode layoutNode = new KNode();
            IKShapeLayout shapeLayout = new KShapeLayout();
            shapeLayout.Insets = new KInsets();
            layoutNode.KShapeLayout = shapeLayout;
            return layoutNode;
        
        }
    }
}
