using KLay.Core.KGraph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klay.Layered.graph.transform
{
    public class KGraphImporter
    {
        public void SetGraphProperties(KNode kgraph)
        {
            //always graph goes to right.
            kgraph.KShapeLayout.LayoutDirection = KLay.Kiml.Enums.LayoutDirectionEnum.RIGHT;
            
                
        }
    }
}
