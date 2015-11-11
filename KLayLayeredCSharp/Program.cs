using KLay.Core.KGraph;
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
            IKNode childNode = kimUtil.CreateInitializedKNode();
            childNode.Parent = parentNode;

            
            return parentNode;

        }
    }
}
