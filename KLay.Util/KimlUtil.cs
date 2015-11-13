using KLay.Core.KGraph;
using KLay.Core.KGraph.Entities;
using KLay.Core.KGraph.Interfaces;
using KLay.Kiml;
using KLay.Kiml.Entities;
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

        public KLabel CreateInitializedKLabel(IKNode parent)
        {
            KLabel label = new KLabel();
            IKShapeLayout shapeLayout = new KShapeLayout();
            label.KShapeLayout = shapeLayout;
            label.Text = "";
            label.Parent = parent;
            return label;
            
        }

        public KPort CreateInitializedPort()
        {
            KPort port = new KPort();
            IKShapeLayout shapeLayout = new KShapeLayout();
            shapeLayout.Insets = new KInsets();
            port.KShapeLayout = shapeLayout;
            return port;
        }


        public KEdge CreateInitializedEdge()
        {
            KEdge edge = new KEdge();
            IKEdgeLayout edgeLayout = new KEdgeLayout();
            edgeLayout.SourcePoint = new KPoint();
            edgeLayout.TargetPoint = new KPoint();
            edge.EdgeLayout = edgeLayout;
            return edge;
        }

    }
}
