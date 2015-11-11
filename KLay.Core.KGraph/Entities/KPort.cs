using KLay.Core.KGraph.Interfaces;
using KLay.Kiml.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLay.Core.KGraph.Entities
{
    public class KPort
    {
        public IKNode Node { get; set; }

        public IKShapeLayout KShapeLayout { get; set; }

    }
}
