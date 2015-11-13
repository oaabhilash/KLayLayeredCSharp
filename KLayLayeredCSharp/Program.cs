using KLay.Core.KGraph;
using KLay.Core.KGraph.Entities;
using KLay.Core.KGraph.Interfaces;
using KLay.Util;
using KLay.Util.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLayLayeredCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            IKNode rootNode = createGraph();

            Console.WriteLine("done");
        }

        public static IKNode createGraph()
        {
            //TODO:: Use Ninject
            IKimlUtil kimUtil = new KimlUtil();

            IKNode parentNode = kimUtil.CreateInitializedKNode();
            IKNode childNode1 = kimUtil.CreateInitializedKNode();
            childNode1.Parent = parentNode;

            IKNode childNode2 = kimUtil.CreateInitializedKNode();
            childNode2.Parent = parentNode;


            KLabel nodeLabel1 = kimUtil.CreateInitializedKLabel(childNode1);
            nodeLabel1.Text = "Node1";

            KLabel nodeLabel2 = kimUtil.CreateInitializedKLabel(childNode2);
            nodeLabel2.Text = "Node2";


            KPort port1 = kimUtil.CreateInitializedPort();
            port1.Node = childNode1;

            KPort port2 = kimUtil.CreateInitializedPort();
            port2.Node = childNode2;


            KEdge edge1 = kimUtil.CreateInitializedEdge();
            edge1.SourceNode = childNode1;
            edge1.TargetNode = childNode2;

            edge1.SourcePort = port1;
            port1.EdgeList.Add(edge1);

            edge1.TargetPort = port2;
            port2.EdgeList.Add(edge1);

            return parentNode;

        }
    }
}
